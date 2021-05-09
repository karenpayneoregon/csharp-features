using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using static ConsoleHelpers.ConsoleKeysHelper;


namespace ConsoleNetCoreApp1
{
    class Program
    {
static void Main(string[] args)
{
    var value = ReadLineWithTimeout(5, "Please enter your name within the next 5 seconds.");
    Console.WriteLine(value);
}

        private static async Task Example1()
        {
            Console.WriteLine("Enter some text");
            var task = Task.Factory.StartNew(Console.ReadLine);
            var completedTask = await Task.WhenAny(task, Task.Delay(TimeSpan.FromSeconds(5)));
            var result = ReferenceEquals(task, completedTask) ? task.Result : string.Empty;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
