using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Determine if value is positive
        /// </summary>
        /// <typeparam name="T">Type implementing IComparable</typeparam>
        /// <param name="value">Value to test</param>
        /// <returns>true if positive, false otherwise</returns>
        public static bool IsPositive<T>(this T value) where T : struct, IComparable<T> =>
            value.CompareTo(default(T)) > 0;

        /// <summary>
        /// Determine if value is negative
        /// </summary>
        /// <typeparam name="T">Type implementing IComparable</typeparam>
        /// <param name="value">Value to test</param>
        /// <returns>true if negative, false otherwise</returns>
        public static bool IsNegative<T>(this T value) where T : struct, IComparable<T> =>
            value.CompareTo(default(T)) == -1;

        public static bool Between<T>(this T value, T lowerValue, T upperValue) where T : struct, IComparable<T>
        {
            return Comparer<T>.Default.Compare(value, lowerValue) >= 0 && Comparer<T>.Default.Compare(value, upperValue) <= 0;
        }
    }
}
