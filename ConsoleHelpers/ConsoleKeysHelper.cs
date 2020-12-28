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
        /// <returns>Input from a Task or if no input an empty string</returns>
        /// <remarks>
        /// Example, wait for two seconds
        /// ConsoleReadLineWithTimeout(TimeSpan.FromSeconds(2.5))
        /// 
        /// Example, use default, wait for one second
        /// ConsoleReadLineWithTimeout(TimeSpan.FromSeconds())
        /// 
        /// For more on working with TimeSpan
        /// https://docs.microsoft.com/en-us/dotnet/api/system.timespan?view=netframework-4.8
        /// 
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

	}
}
