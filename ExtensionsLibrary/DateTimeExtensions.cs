using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Convert TimeSpan into DateTime
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        /// <remarks>
        /// Intended to be used when the date part does not matter
        /// </remarks>
        public static DateTime ToDateTime(this TimeSpan sender) => DateTime.ParseExact(sender.Formatted("hh:mm"), "H:mm", null, DateTimeStyles.None);

        /// <summary>
        /// Format a TimeSpan with AM PM
        /// </summary>
        /// <param name="sender">TimeSpan to format</param>
        /// <param name="format">Optional format</param>
        /// <returns></returns>
        public static string Formatted(this TimeSpan sender, string format = "hh:mm tt") => DateTime.Today.Add(sender).ToString(format);
    }
}
