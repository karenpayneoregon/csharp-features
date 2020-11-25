using System;

namespace ExtensionsLibrary
{
    public static class Extensions
    {
        /// <summary>
        /// Case insensitive contains
        /// </summary>
        /// <param name="source"></param>
        /// <param name="substring"></param>
        /// <returns></returns>
        public static bool ContainsIgnoreCase(this string source, string substring) => 
            source?.IndexOf(substring ?? "", StringComparison.OrdinalIgnoreCase) >= 0;

        /// <summary>
        /// Flip negative to positive or positive to negative
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static int Invert(this int source) => source * (-1);
        /// <summary>
        /// Flip negative to positive or positive to negative alternative via bitwise operation
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static int InvertBitwise(this int source) => 
            ~source + 1;

        /// <summary>
        /// Determine if value is positive
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsPositive<T>(this T value) where T : struct, IComparable<T> => 
            value.CompareTo(default(T)) > 0;

        /// <summary>
        /// Determine if value is negative
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNegative<T>(this T value) where T : struct, IComparable<T> => 
            value.CompareTo(default(T)) == -1;

    }

}