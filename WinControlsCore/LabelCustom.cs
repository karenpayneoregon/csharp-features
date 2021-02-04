using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControlsCore
{
    public class LabelCustom : Label
    {
        [Category("Behavior"), Description("Identifier")]
        public int? Id { get; set; }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public bool HasId => Id.HasValue;
        [Category("Behavior"), Description("Comment")]
        public string Comment { get; set; }
    }
}
