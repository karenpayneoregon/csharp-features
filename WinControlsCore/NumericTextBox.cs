using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinControlsCore
{
    /// <summary>
    /// A TextBox that only allows digits to be entered.
    /// </summary>
    [Description("A TextBox that only allows digits to be entered.")]
    public class NumericTextBox : TextBox
    {

        [Category("Behavior"), Description("Identifier")]
        public int? Id { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public bool HasId => Id.HasValue;
        [Category("Behavior"), Description("Comment")]
        public string Comment { get; set; }
        #region Enums

        /// <summary>
        /// A enum of reasons why a paste was rejected.
        /// </summary>
        public enum PasteRejectReasons
        {
            Unknown = 0,
            NoData,
            InvalidCharacter,
            Accepted
        }

        #endregion

        #region Constants

        /// <summary>
        /// Windows message that is sent when a paste event occurs.
        /// </summary>
        public const int WM_PASTE = 0x0302;

        #endregion

        #region Events

        /// <summary>
        /// Occurs whenever a KeyDown event is suppressed.
        /// </summary>
        [Category("Behavior"),
        Description("Occurs whenever a KeyDown event is suppressed.")]
        public event EventHandler<KeyRejectedEventArgs> KeyRejected;

        /// <summary>
        /// Occurs whenever a paste attempt is suppressed.
        /// </summary>
        [Category("Behavior"),
        Description("Occurs whenever a paste attempt is suppressed.")]
        public event EventHandler<PasteEventArgs> PasteRejected;

        #endregion

        #region Private Variables

        /// <summary>
        /// The last Text of the control.
        /// </summary>
        private string _defaultText;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the default value for the control.
        /// </summary>
        [DefaultValue("0"),
        Category("Appearance"),
        Browsable(true)]
        public string DefaultText
        {
            get => _defaultText;
            set
            {
                var oldValue = _defaultText;
                if (_defaultText != value)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        _defaultText = value;
                        if (Text == oldValue)
                            Text = _defaultText;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("value", "The default text cannot be empty.");
                    }
                }
            }
        }

        // New Text property to enable a new default value.
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [DefaultValue("0"),
        Category("Appearance"),
        Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        // New HorizontalAlignment property to enable a new default value.
        /// <summary>
        /// Gets or sets the horizontal alignment of the text.
        /// </summary>
        [DefaultValue(typeof(HorizontalAlignment), "Right"),
        Category("Appearance")]
        public new HorizontalAlignment TextAlign
        {
            get => base.TextAlign;
            set => base.TextAlign = value;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new instance of the NumericTextBox
        /// </summary>
        public NumericTextBox()
        {
            TextAlign = HorizontalAlignment.Right;
            _defaultText = "0";
            Text = _defaultText;
        }

        #endregion

        #region Overridden Methods

        /// <summary>
        /// Raises the OnGotFocus event.
        /// </summary>
        /// <param name="e">A System.EventArgs that contains the event data.</param>
        protected override void OnGotFocus(EventArgs e)
        {
            // Select all text every time control gets focus.
            SelectAll();
            base.OnGotFocus(e);
        }

        /// <summary>
        /// Raises the KeyDownEvent.
        /// </summary>
        /// <param name="e">A System.Windows.Forms.KeyEventArgs that contains the event data.</param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            bool result = true;
            bool numericKeys = (((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)) && e.Modifiers != Keys.Shift);
            bool ctrlA = e.KeyCode == Keys.A && e.Modifiers == Keys.Control;
            bool editKeys = (
                (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control) ||
                (e.KeyCode == Keys.X && e.Modifiers == Keys.Control) ||
                (e.KeyCode == Keys.C && e.Modifiers == Keys.Control) ||
                (e.KeyCode == Keys.V && e.Modifiers == Keys.Control) ||
                e.KeyCode == Keys.Delete ||
                e.KeyCode == Keys.Back);
            bool navigationKeys = (
                e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Home ||
                e.KeyCode == Keys.End);

            if (!(numericKeys || editKeys || navigationKeys))
            {
                if (ctrlA) // Do select all as OS/Framework does not always seem to implement this.
                {
                    SelectAll();
                }

                result = false;
            }
            if (!result) // If not valid key then suppress and handle.
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                if (ctrlA) { } // Do Nothing!
                else
                {
                    OnKeyRejected(new KeyRejectedEventArgs(e.KeyCode));
                }
            }
            else
            {
                base.OnKeyDown(e);
            }
        }

        /// <summary>
        /// Raises the LostFocus event.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected override void OnLostFocus(EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                Text = _defaultText;
            }

            base.OnLostFocus(e);

        }

        /// <summary>
        /// Raises the TextChanged event.
        /// </summary>
        /// <param name="e">A System.EventArgs that contains the event data.</param>
        protected override void OnTextChanged(EventArgs e)
        {
            bool invalid = string.IsNullOrWhiteSpace(Text);

            foreach (var character in Text) // Check for any non digit characters.
            {

                if (!char.IsDigit(character))
                {
                    invalid = true;
                    break; ;
                }
            }

            if (invalid)
            {
                Text = _defaultText;
                SelectAll();
                return;
            }

            base.OnTextChanged(e);
        }

        /// <summary>
        /// Receives Windows messages to optionally process.
        /// </summary>
        /// <param name="m">The Windows message to process.</param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PASTE)
            {

                PasteEventArgs e = CheckPasteValid();

                if (e.RejectReason != PasteRejectReasons.Accepted)
                {
                    m.Result = IntPtr.Zero;
                    OnPasteRejected(e);
                    return;
                }
            }
            base.WndProc(ref m);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Checks if the data on the clipboard contains text that is valid.
        /// </summary>
        /// <returns>A PasteEventArgs instance containing the relevant data.</returns>
        private PasteEventArgs CheckPasteValid()
        {
            // Default values.
            PasteRejectReasons rejectReason = PasteRejectReasons.Accepted;

            var originalText = Text;
            var clipboardText = string.Empty;
            var textResult = string.Empty;

            try
            {
                clipboardText = Clipboard.GetText(TextDataFormat.Text);

                if (clipboardText.Length > 0) // Does clipboard contain text?
                {
                    textResult = (Text.Remove(SelectionStart, SelectionLength).Insert(SelectionStart, clipboardText));

                    foreach (char character in clipboardText)
                    {
                        if (!char.IsDigit(character))
                        {
                            rejectReason = PasteRejectReasons.InvalidCharacter;
                            break;
                        }
                    }
                }
                else
                {
                    rejectReason = PasteRejectReasons.NoData;
                }
            }
            catch
            {
                rejectReason = PasteRejectReasons.Unknown;
            }

            return new PasteEventArgs(originalText, clipboardText, textResult, rejectReason);
        }

        #endregion

        #region Event Raise Methods

        /// <summary>
        /// Raises the KeyRejected event.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected virtual void OnKeyRejected(KeyRejectedEventArgs e)
        {
            EventHandler<KeyRejectedEventArgs> handler = KeyRejected;
            handler?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the PasteRejected event.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected virtual void OnPasteRejected(PasteEventArgs e)
        {
            EventHandler<PasteEventArgs> handler = PasteRejected;
            handler?.Invoke(this, e);
        }

        #endregion

        #region EventArg Classes

        /// <summary>
        /// Event arguments class for the KeyRejected event.
        /// </summary>
        public class KeyRejectedEventArgs : EventArgs
        {
            #region Private Variables

            private Keys _mKey;

            #endregion

            #region Properties

            /// <summary>
            /// Gets the rejected key.
            /// </summary>
            [ReadOnly(true)]
            public Keys Key => _mKey;

            #endregion

            #region Constructor

            /// <summary>
            /// Creates a new instance of the KeyRejectedEventArgs class.
            /// </summary>
            /// <param name="key">The rejected key.</param>
            public KeyRejectedEventArgs(Keys key) => _mKey = key;

            #endregion

            #region Overridden Methods

            /// <summary>
            /// Converts this KeyRejectedEventArgs instance into it's string representation.
            /// </summary>
            /// <returns>A string indicating the rejected key.</returns>
            public override string ToString() => $"Rejected Key: {Key.ToString()}";

            #endregion
        }

        /// <summary>
        /// Event arguments class for the PasteRejected event.
        /// </summary>
        public class PasteEventArgs : EventArgs
        {
            #region Private Variables

            private string _originalText;
            private string _clipboardText;
            private string _textResult;
            private PasteRejectReasons _mRejectReason;

            #endregion

            #region Properties

            /// <summary>
            /// Gets the original text.
            /// </summary>
            [ReadOnly(true)]
            public string OriginalText => _originalText;

            /// <summary>
            /// Gets the text from the clipboard.
            /// </summary>
            [ReadOnly(true)]
            public string ClipboardText => _clipboardText;

            /// <summary>
            /// Gets the resulting text.
            /// </summary>
            [ReadOnly(true)]
            public string TextResult => _textResult;

            /// <summary>
            /// Gets the reason for the paste rejection.
            /// </summary>
            [ReadOnly(true)]
            public PasteRejectReasons RejectReason => _mRejectReason;

            #endregion

            #region Constructor

            /// <summary>
            /// Creates a new instance of the PasteRejectedEventArgs class.
            /// </summary>
            /// <param name="originalText">The original textl.</param>
            /// <param name="clipboardText">The text from the clipboard.</param>
            /// <param name="textResult">The resulting text.</param>
            /// <param name="rejectReason">The reason for the paste rejection.</param>
            public PasteEventArgs(string originalText, string clipboardText, string textResult, PasteRejectReasons rejectReason)
            {
                _originalText = originalText;
                _clipboardText = clipboardText;
                _textResult = textResult;
                _mRejectReason = rejectReason;
            }

            #endregion

            #region Overridden Methods

            /// <summary>
            /// Converts this PasteRejectedEventArgs instance into it's string representation.
            /// </summary>
            /// <returns>A string indicating the rejected reason.</returns>
            public override string ToString() => $"Rejected reason: {RejectReason}";

            #endregion
        }

        #endregion
    }
}
