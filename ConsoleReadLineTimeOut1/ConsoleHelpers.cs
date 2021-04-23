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
        /// <returns><see cref="DateTime"/></returns>
        public static string ReadLineAsString() => ReadLine();
        /// <summary>
        /// Read line, convert to DateTime
        /// </summary>
        /// <returns></returns>
        public static DateTime? ReadLineAsDate() => DateTime.TryParse(ReadLineAsString(), out var result) ? result as DateTime? : null;
        /// <summary>
        /// Read line and convert to int
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int? ReadLineAsInt() => int.TryParse(ReadLineAsString(), out var result) ? (int?) result : null;
        public static double? ReadLineAsDouble() => double.TryParse(ReadLineAsString(), out var result) ? (double?) result : null;
        /// <summary>
        /// Read line and convert to <see cref="DateTime"/> with timeout
        /// </summary>
        /// <returns><see cref="DateTime"/></returns>
        public static DateTime? ReadLineAsDateTimeout(TimeSpan? timeout = null) => DateTime.TryParse(ReadLineAsStringTimeout(timeout), out var result) ? result : null;
        /// <summary>
        /// Read line and convert to <see cref="int"/> with timeout
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int? ReadLineAsIntTimeout(TimeSpan? timeout = null) => int.TryParse(ReadLineAsStringTimeout(timeout), out var result) ? result : null;
        /// <summary>
        /// Read line and convert to <see cref="TimeSpan"/> with timeout
        /// </summary>
        /// <returns><see cref="TimeSpan"/></returns>
        public static double? ReadLineAsDoubleTimeout(TimeSpan? timeout = null) => double.TryParse(ReadLineAsStringTimeout(timeout), out var result) ? result : null;
        /// <summary>
        /// Read line and convert to <see cref="string"/> with five seconds timeout
        /// </summary>
        /// <returns><see cref="string"/></returns>
        public static string ReadLineWaitFiveSeconds() => ReadLineAsStringTimeout(TimeSpan.FromSeconds(5));
        /// <summary>
        /// Read line and convert to <see cref="string"/> with ten seconds timeout
        /// </summary>
        /// <returns><see cref="string"/></returns>
        public static string ReadLineWaitTenSeconds() => ReadLineAsStringTimeout(TimeSpan.FromSeconds(10));
        /// <summary>
        /// Read line and convert to <see cref="string"/> with thirty seconds timeout
        /// </summary>
        /// <returns><see cref="string"/></returns>
        public static string ReadLineWaitThirtySeconds() => ReadLineAsStringTimeout(TimeSpan.FromSeconds(30));
        /// <summary>
        /// Read line and convert to <see cref="string"/> with thirty seconds timeout
        /// </summary>
        /// <returns><see cref="string"/></returns>
        public static string ReadLineWaitOneMinutes() => ReadLineAsStringTimeout(TimeSpan.FromMinutes(1));
        /// <summary>
        /// Read line and convert to <see cref="DateTime"/> with one minute timeout
        /// </summary>
        /// <returns><see cref="DateTime"/></returns>
        public static DateTime? ReadLineDateTimeWaitTenSeconds() => ReadLineAsDateTimeout(TimeSpan.FromSeconds(10));
        public static int? ReadLineIntTimeWaitTenSeconds() => ReadLineAsIntTimeout(TimeSpan.FromSeconds(10));
        /// <summary>
        /// Read line and convert to <see cref="int"/> with one minute timeout
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int? ReadLineIntTimeWait() => ReadLineAsIntTimeout();
        /// <summary>
        /// Convert bool to Yes, No
        /// </summary>
        /// <param name="value"><see cref="bool"/></param>
        /// <returns>Yes or No</returns>
        public static string ToYesNoString(this bool value) => value ? "Yes" : "No";
    }
}