using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public static class StringExtensions
    {
        /// <summary>
        /// Case insensitive contains
        /// </summary>
        /// <param name="source">string to locate sub string</param>
        /// <param name="substring">string to find in source</param>
        /// <returns>if substring is in source</returns>
        public static bool ContainsIgnoreCase(this string source, string substring) =>
            source?.IndexOf(substring ?? "", StringComparison.OrdinalIgnoreCase) >= 0;

        /// <summary>
        /// Split string on upper cased letters
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string SplitCamelCase(this string sender) => 
            Regex.Replace(Regex.Replace(
                sender, 
                "(\\P{Ll})(\\P{Ll}\\p{Ll})", "$1 $2"), 
                "(\\p{Ll})(\\P{Ll})", "$1 $2");

        /// <summary>
        /// Join string array with " and " as the last delimiter.
        /// </summary>
        /// <param name="sender">String array to convert to delimited string</param>
        /// <returns>Delimited string</returns>
        public static string JoinWithLastSeparator(this string[] sender) => 
            string.Join(", ", sender.Take(sender.Length - 1)) + ((((sender.Length <= 1) ? "" : " and ")) + sender.LastOrDefault());

        /// <summary>
        /// Join string array with specified delimiter, " and " for the last delimiter
        /// </summary>
        /// <param name="sender">String array to convert to delimited string</param>
        /// <param name="pDelimiter">Delimiter to separate array items</param>
        /// <returns>Delimited string</returns>
        public static string JoinWithLastSeparator(this string[] sender, string pDelimiter) => 
            string.Join(pDelimiter + " ", sender.Take(sender.Length - 1)) + ((((sender.Length <= 1) ? "" : " and ")) + sender.LastOrDefault());

        /// <summary>
        /// Join string array with specified delimiter and last delimiter
        /// </summary>
        /// <param name="sender">String array to convert to delimited string</param>
        /// <param name="pDelimiter">Delimiter to separate array items</param>
        /// <param name="pLastDelimiter">Token used for final delimiter</param>
        /// <returns>Delimited string</returns>
        public static string JoinWithLastSeparator(this string[] sender, string pDelimiter, string pLastDelimiter) => 
            string.Join(pDelimiter + " ", sender.Take(sender.Length - 1)) + ((((sender.Length <= 1) ? "" : pLastDelimiter)) + sender.LastOrDefault());

        /// <summary>
        /// Replace any strings with more than one space with a single space
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="replaceWith"></param>
        /// <returns></returns>
        public static string RemoveDoubleSpacings(this string sender, string replaceWith = "")
        {
            var options = RegexOptions.None;
            var regex = new Regex("[ ]{2,}", options);

            sender = regex.Replace(sender, replaceWith);

            return sender;
        }
    }

}
