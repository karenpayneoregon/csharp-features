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

        /// <summary>
        /// Determine if T is between lower and upper
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="value">Value to determine if between lower and upper</param>
        /// <param name="lowerValue">Lower of range</param>
        /// <param name="upperValue">Upper of range</param>
        /// <returns>True if in range, false if not in range</returns>
        /// <example>
        /// <code>
        /// var startDate = new DateTime(2018, 12, 2, 1, 12, 0);
        /// var endDate = new DateTime(2018, 12, 15, 1, 12, 0);
        /// var theDate = new DateTime(2018, 12, 13, 1, 12, 0);
        /// Assert.IsTrue(theDate.Between(startDate,endDate));
        /// </code>
        /// </example>
        public static bool Between<T>(this T value, T lowerValue, T upperValue) where T : struct, IComparable<T> => 
            Comparer<T>.Default.Compare(value, lowerValue) >= 0 && Comparer<T>.Default.Compare(value, upperValue) <= 0;

        /// <summary>
        /// Determine if T is less than maximumValue 
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="sender">Value to test</param>
        /// <param name="maximumValue">Max value</param>
        /// <returns></returns>
        public static bool LessThan<T>(this IComparable<T> sender, T maximumValue) =>
            sender.CompareTo(maximumValue) <= 0;

        public static List<T> GetRange<T>(this List<T> list, Range range)
        {
            var (start, length) = range.GetOffsetAndLength(list.Count);
            return list.GetRange(start, length);
        }

    }
}
