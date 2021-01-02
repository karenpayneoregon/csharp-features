using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadExceptionWindowsFormsApp.LanguageExtensions
{
    public static class ListViewExtensions
    {
        /// <summary>
        /// Get exception lines
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string[] LineTag(this ListViewItem sender) => ((List<string>)sender.Tag).ToArray();

        public static string ExceptionDetails(this ListViewItem sender) => $"{sender.Text}, {sender.SubItems[1].Text}";
    }
}
