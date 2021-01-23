using System;
using System.Windows.Forms;

namespace ParsingArray.Extensions
{
    public static class ControlExtensions
    {
        public static string[] ToStringArray(this TextBox textBox, char separator = ' ') => 
            textBox.Text.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);
    }
}
