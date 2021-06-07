using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DescendantsDemo.Classes
{
    public static class ControlExtensions
    {
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                T thisControl = child as T;
                if (thisControl != null)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }

        public static List<TextBox> TextBoxList(this Control control) => control.Descendants<TextBox>().ToList();
    }
}
