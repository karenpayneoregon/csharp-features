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
        /// Get primary and foreign keys for a product
        /// within a ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string[] LineTag(this ListViewItem sender)
        {
            return ((List<string>)sender.Tag).ToArray();
        }
    }
}
