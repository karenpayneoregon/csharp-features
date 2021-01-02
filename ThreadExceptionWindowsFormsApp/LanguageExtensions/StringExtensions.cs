using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExceptionWindowsFormsApp.LanguageExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Convert string array to a delimited string
        /// </summary>
        /// <param name="sender">string array</param>
        /// <param name="separator">separator between elements, defaults to new line</param>
        /// <returns></returns>
        public static string AsString(this string[] sender, string separator = "\n") => string.Join(separator, sender);
    }
}
