using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleHelpers.ConsoleColors;

namespace ConsoleHelpers
{
    public static class ConsoleKeysHelper
    {
        public static void WaitReadLine(string message = "Press any key to terminate.")
        {
            WriteSectionBold(message,false);
            Console.ReadLine();
        }

        /// <summary>
        /// Provides an enhanced Console.ReadLine with a time out.
        /// </summary>
        /// <param name="timeout">Timeout</param>
        /// <param name="message">Optional text to display</param>
        /// <returns>Input from a Task or if no input an empty string</returns>
        /// <remarks>
        /// Example, wait for two seconds and a half
        /// ConsoleReadLineWithTimeout(TimeSpan.FromSeconds(2.5))
        /// 
        /// Example, use default, wait for one second
        /// ConsoleReadLineWithTimeout(TimeSpan.FromSeconds())
        /// </remarks>
        public static string ReadLineWithTimeout(TimeSpan? timeout = null, string message = "")
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                WriteSectionBold(message, false);
            }
            
            TimeSpan timeSpan = timeout ?? TimeSpan.FromSeconds(1);
            var task = Task.Factory.StartNew(Console.ReadLine);
            var result = (Task.WaitAny(new Task[] { task }, timeSpan) == 0) ? task.Result : string.Empty;

            return result;

        }
        /// <summary>
        /// Read line with timeout and optional message
        /// </summary>
        /// <param name="seconds"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string ReadLineWithTimeout(int seconds, string message = "")
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                WriteSectionBold(message, false);
            }

            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            var task = Task.Factory.StartNew(Console.ReadLine);
            
            var result = (Task.WaitAny(new Task[] { task }, timeSpan) == 0) ? task.Result : string.Empty;

            return result;

        }

        public static string ReadLineFiveSeconds(string message = "") => ReadLineWithTimeout(5, message);
        public static string PauseFiveSeconds(string message = "") => ReadLineWithTimeout(5, message);
        
        public static string ReadLineTenSeconds(string message = "") => ReadLineWithTimeout(10, message);
        public static string PauseTenSeconds(string message = "") => ReadLineWithTimeout(10, message);
    }
}
