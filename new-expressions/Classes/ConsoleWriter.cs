using System;
using System.Collections.Generic;
using System.Text;

namespace NewExpressions.Classes
{
    static class ConsoleWriter
    {
        public static void WriteConsoleColor(params ColoredString[] strings)
        {
            var originalColor = Console.ForegroundColor;
            foreach (var item in strings)
            {
                Console.ForegroundColor = item.Color;
                Console.Write(item.Text);
            }
            Console.ForegroundColor = originalColor;
        }

        public static void WriteConsoleColorNewLine(params ColoredString[] strings)
        {
            var originalColor = Console.ForegroundColor;
            for (var index = 0; index < strings.Length; index++)
            {
                var item = strings[index];
                Console.ForegroundColor = item.Color;
                Console.Write(index == strings.Length - 1 ? $"{item.Text}\n" : $"{item.Text}");
            }

            Console.ForegroundColor = originalColor;
        }
    }
}
