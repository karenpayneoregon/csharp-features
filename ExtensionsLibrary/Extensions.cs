using System;

namespace ExtensionsLibrary
{
    public static class Extensions
    {
        public static bool ContainsIgnoreCase(this string source, string substring) => 
            source?.IndexOf(substring ?? "", StringComparison.OrdinalIgnoreCase) >= 0;

        public static int Invert(this int source) => source * (-1);
        public static int InvertBitwise(this int source) => ~source + 1;

        public static bool IsPositive<T>(this T value) where T : struct, IComparable<T> => 
            value.CompareTo(default(T)) > 0;

        public static bool IsNegative<T>(this T value) where T : struct, IComparable<T> => 
            value.CompareTo(default(T)) == -1;
    }

}