using System;
using static System.Console;

namespace SwitchExpressionConsole
{
    /// <summary>
    /// Default value for unexpected value
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Example1();
            WriteLine();
            Example2();

            ReadLine();
        }

        private static void Example2()
        {
            int value = -2;

            WriteLine(value switch
            {
                -1 => "Minus 1",
                -2 => "Minus 2",
                _ => "Do not know what to do with this"
            });
        }

        private static void Example1()
        {
            var value = -22;

            var resultText = value switch
            {
                -1 => "Minus 1",
                -2 => "Minus 2",
                _ => "Do not know what to do with this"
            };

            WriteLine(resultText);
        }
    }

  
}
