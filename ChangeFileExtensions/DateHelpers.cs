using System;

namespace ChangeFileExtensions
{
    public static class DateHelpers
    {
        public static bool RouteCheck(ref DateTime? travelTime) => travelTime.HasValue;
        public static DateTime? TryParseDateTime(string text) => DateTime.TryParse(text, out var value) ? value : (DateTime?)null;
        public static int? TryParseInt(string text) => int.TryParse(text, out var value) ? value : (int?)null;
        public static bool Is<T>(this string value)
        {
            if (string.IsNullOrEmpty(value)) return false;
            var conv = System.ComponentModel.TypeDescriptor.GetConverter(typeof(T));

            if (!conv.CanConvertFrom(typeof(string))) return false;
            
            try
            {
                conv.ConvertFrom(value);
                return true;
            }
            catch
            {
                // ignored
            }
            return false;
        }
    }
}