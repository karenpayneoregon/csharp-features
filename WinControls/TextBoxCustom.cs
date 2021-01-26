using System.ComponentModel;
using System.Windows.Forms;

namespace WinControls
{
    public class TextBoxCustom : TextBox
    {
        [Category("Behavior"), Description("Identifier")]
        public int Id { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public bool HasId => Id > 0;
    }
}
