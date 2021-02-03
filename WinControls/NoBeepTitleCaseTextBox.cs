using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace WinControls
{
	/// <summary>
	/// * Suppress beep on ENTER key pressed
	/// * Provides ability to title case text
	/// </summary>
	public class NoBeepTitleCaseTextBox : TextBox
	{
		public delegate void TriggerDelegate();
		/// <summary>
		/// Subscribe to be notified when ENTER was pressed.
		/// </summary>
		public event TriggerDelegate TriggerEvent;
		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{

				e.Handled = true;
				e.SuppressKeyPress = true;

				if (ToTitleCase)
				{
					HandleCasing();
				}


				TriggerEvent?.Invoke();

				return;

			}

			base.OnKeyDown(e);
		}
		/// <summary>
		/// Use to transform .Text to title case.
		/// </summary>
		private void HandleCasing()
        {
            if (!_useTitleCase) return;

            var textInfo = (new CultureInfo(_cultureKey, false)).TextInfo;

            if (_uppercaseOption)
            {
                Text = Text.ToLower();
            }

            Text = textInfo.ToTitleCase(Text);
            SelectionStart = Text.Length;
            SelectionLength = 0;

        }
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("Title case culture")]
        [DisplayName("CultureKey")]
		public string CultureKey
        {
            get => _cultureKey ?? "en-US";
            set => _cultureKey = value;
        }

        private bool _useTitleCase;
		private bool _uppercaseOption;
        private string _cultureKey;

        [Browsable(true)]
		[Category("Extended Properties")]
		[Description("Set text to title case")]
		[DisplayName("ToTitleCase")]
		public bool ToTitleCase
		{
			get => _useTitleCase;
            set => _useTitleCase = value;
        }
		[Browsable(true)]
		[Category("Extended Properties")]
		[Description("Override casing when all text may be uppercased")]
		[DisplayName("OverrideUpperCased")]
		public bool OverrideUpperCased
		{
			get => _uppercaseOption;
            set => _uppercaseOption = value;
        }
		/// <summary>
		/// We can not trap TAB in OnKeyDown so handle it here
		/// then permit default via MyBase.ProcessCmdKey
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="keyData"></param>
		/// <returns></returns>
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Tab)
			{
				if (ToTitleCase)
				{
					HandleCasing();
				}
			}

			return base.ProcessCmdKey(ref msg, keyData);

		}

	}
}
