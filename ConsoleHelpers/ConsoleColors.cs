using System;
using System.Drawing;
using static System.Console;

namespace ConsoleHelpers
{
    public static class ConsoleColors
    {
        public static void WriteHeader(string message)
        {
            var item = new ConsoleRectangle(30, 1,new Point(0,0), ConsoleColor.Magenta, message);
            item.Draw();
        }
        public static void WriteSectionYellow(string message, bool line = true)
        {
            var originalForeColor = ForegroundColor;

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine(message);
            ForegroundColor = originalForeColor;
            if (line)
            {
                WriteLine(new string('-', 100));
            }
            
        }
        
        public static void WriteSectionBold(string message, bool line = true)
        {
            var originalForeColor = ForegroundColor;

            ForegroundColor = ConsoleColor.White;
            WriteLine(message);
            ForegroundColor = originalForeColor;
            if (line)
            {
                WriteLine(new string('-', 100));
            }

        }
        public static void WriteSectionBoldIndented(string message, bool line = true)
        {
            var originalForeColor = ForegroundColor;

            ForegroundColor = ConsoleColor.White;
            WriteLine($"\t{message}");
            ForegroundColor = originalForeColor;
            if (line)
            {
                WriteLine(new string('-', 100));
            }

        }
        public static void WriteIndented(string message)
        {
            WriteLine($"\t{message}");
        }

        public static void EmptyLine() => WriteLine("");
        
        public static void WriteIndented(int message)
        {
            WriteLine($"\t{message}");
        }
        public static void WriteIndented(bool message)
        {
            WriteLine($"\t{message}");
        }
    }
}
