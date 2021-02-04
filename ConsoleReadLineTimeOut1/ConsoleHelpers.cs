using System;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleReadLineTimeOut1
{
    public static class ConsoleHelpers
    {
        public static double DefaultTimeOut { get; set; } = 10;
        /// <summary>
        /// Wait a specific amount of time for Console.ReadLine. Must press ENTER to collect input or no key to timeout
        /// </summary>
        /// <param name="timeout">Valid time span or if not passed default to <see cref="DefaultTimeOut"/> in seconds</param>
        /// <returns>Input from ReadLine or an empty string</returns>
        public static string ReadLineAsStringTimeout(TimeSpan? timeout = null)
        {
            var timeSpan = timeout ?? TimeSpan.FromSeconds(DefaultTimeOut);
            var task = Task.Factory.StartNew(ReadLine);
            var value = (Task.WaitAny(new Task[] { task }, timeSpan) == 0) ? task.Result : string.Empty;

            return value;

        }
        /// <summary>
        /// Verbose method name for reading a string
        /// </summary>
        /// <returns></returns>
        public static string ReadLineAsString() => ReadLine();

        public static DateTime? ReadLineAsDate() => DateTime.TryParse(ReadLineAsString(), out var result) ? result as DateTime? : null;
        public static int? ReadLineAsInt() => int.TryParse(ReadLineAsString(), out var result) ? (int?) result : null;
        public static double? ReadLineAsDouble() => double.TryParse(ReadLineAsString(), out var result) ? (double?) result : null;
        
        public static DateTime? ReadLineAsDateTimeout(TimeSpan? timeout = null) => DateTime.TryParse(ReadLineAsStringTimeout(timeout), out var result) ? result : null;
        public static int? ReadLineAsIntTimeout(TimeSpan? timeout = null) => int.TryParse(ReadLineAsStringTimeout(timeout), out var result) ? result : null;
        public static double? ReadLineAsDoubleTimeout(TimeSpan? timeout = null) => double.TryParse(ReadLineAsStringTimeout(timeout), out var result) ? result : null;
        
        public static string ReadLineWaitFiveSeconds() => ReadLineAsStringTimeout(TimeSpan.FromSeconds(5));
        public static string ReadLineWaitTenSeconds() => ReadLineAsStringTimeout(TimeSpan.FromSeconds(10));
        public static string ReadLineWaitThirtySeconds() => ReadLineAsStringTimeout(TimeSpan.FromSeconds(30));
        public static string ReadLineWaitOneMinutes() => ReadLineAsStringTimeout(TimeSpan.FromMinutes(1));
        
        public static DateTime? ReadLineDateTimeWaitTenSeconds() => ReadLineAsDateTimeout(TimeSpan.FromSeconds(10));
        public static int? ReadLineIntTimeWaitTenSeconds() => ReadLineAsIntTimeout(TimeSpan.FromSeconds(10));
        public static int? ReadLineIntTimeWait() => ReadLineAsIntTimeout();

        public static string ToYesNoString(this bool value) => value ? "Yes" : "No";
    }
}