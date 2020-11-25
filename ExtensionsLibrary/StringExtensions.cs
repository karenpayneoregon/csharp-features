using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
