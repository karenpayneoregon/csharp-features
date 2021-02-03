using System;
using System.Threading.Tasks;
using static System.Console;
using static ConsoleReadLineTimeOut.ConsoleHelpers;

namespace ConsoleReadLineTimeOut
{
    class Program
    {
        static void Main(string[] args)
        {
            var oneMinute = ReadLineWaitOneMinutes();
            WriteLine($"After 1 minute:[{oneMinute}]");
            Console.ReadLine();


            WriteLine("First name");
            Console.ReadLine();
            var firstName = ReadLineWaitFiveSeconds();
            WriteLine(string.IsNullOrWhiteSpace(firstName) ? "No first name" : $"First name: {firstName}");

            WriteLine("Last name");
            var lastName = ReadLineWaitFiveSeconds();
            WriteLine(string.IsNullOrWhiteSpace(lastName) ? "No last name" : $"Last name: {lastName}");

            WriteLine("Done");
            ReadLineWaitTenSeconds();

        }
        
        
    }

    public static class ConsoleHelpers
    {
        /// <summary>
        /// Wait a specific amount of time for Console.ReadLine. Must press ENTER to collect input
        /// </summary>
        /// <param name="timeout">Valid time span or if not passed default to 10 seconds</param>
        /// <returns>Input from ReadLine or an empty string</returns>
        public static string ReadLineAsStringWithTimeout(TimeSpan? timeout = null)
        {
            var timeSpan = timeout ?? TimeSpan.FromSeconds(10);
            var task = Task.Factory.StartNew(ReadLine);
            var result = (Task.WaitAny(new Task[] { task }, timeSpan) == 0) ? task.Result : string.Empty;

            return result;

        }
        
        
        public static string ReadLineWaitFiveSeconds() => ReadLineAsStringWithTimeout(TimeSpan.FromSeconds(5));
        public static string ReadLineWaitTenSeconds() => ReadLineAsStringWithTimeout(TimeSpan.FromSeconds(10));
        public static string ReadLineWaitThirtySeconds() => ReadLineAsStringWithTimeout(TimeSpan.FromSeconds(30));
        public static string ReadLineWaitOneMinutes() => ReadLineAsStringWithTimeout(TimeSpan.FromMinutes(1));
    }
}
