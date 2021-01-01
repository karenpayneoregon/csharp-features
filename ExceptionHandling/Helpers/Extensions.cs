using System;

namespace ExceptionHandling.Helpers
{
    public static class Extensions
    {
        public static TEnum ToEnum<TEnum>(this string enumValue, TEnum defaultValue) => 
            !Enum.IsDefined(typeof(TEnum), enumValue) ? defaultValue : (TEnum) Enum.Parse(typeof(TEnum), enumValue);
    }
}
