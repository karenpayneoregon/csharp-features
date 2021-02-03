using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControls
{
    /// <summary>
    /// TextBox with no beep when ENTER is pressed as is is limited usage.
    /// </summary>
    public class NoBeepTextBox : TextBox
    {
        public delegate void TriggerDelegate();
        /// <summary>
        /// Subscribe to be notified when ENTER was pressed.
        /// </summary>
        public event TriggerDelegate TriggerEvent;
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Return))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                TriggerEvent?.Invoke();

                return;
            }

            base.OnKeyDown(e);
        }

        [Category("Behavior"), Description("Identifier")]
        public int? Id { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public bool HasId => Id.HasValue;
    }
}
