using System;
using System.Drawing;
using static System.Console;

namespace ConsoleHelpers
{
    /// <summary>
    /// Methods to write in color
    /// </summary>
    public static class ConsoleColors
    {
        /// <summary>
        /// Write text in Rectangle
        /// </summary>
        /// <param name="message">Message to display</param>
        public static void WriteHeader(string message)
        {
            var item = new ConsoleRectangle(message, 100, 1, new Point(0, 0));
            item.Draw();
        }
        
        /// <summary>
        /// Write message in yellow foreground
        /// </summary>
        /// <param name="message">Text to display</param>
        /// <param name="line">Add underline</param>
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
        /// <summary>
        /// Write message in White foreground
        /// </summary>
        /// <param name="message">Text to display</param>
        /// <param name="line">Add underline</param>
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
        /// <summary>
        /// Write message in White foreground indented
        /// </summary>
        /// <param name="message">Text to display</param>
        /// <param name="line">Add underline</param>
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
        /// <summary>
        /// Write message indented
        /// </summary>
        /// <param name="message">Text to display</param>
        public static void WriteIndented(string message)
        {
            WriteLine($"\t{message}");
        }
        /// <summary>
        /// Write an empty line
        /// </summary>
        public static void EmptyLine() => WriteLine("");
        /// <summary>
        /// Write int indented line no line
        /// </summary>
        /// <param name="message">int value</param>
        public static void WriteIndented(int message)
        {
            WriteLine($"\t{message}");
        }
        /// <summary>
        /// Write bool indented
        /// </summary>
        /// <param name="message">bool value</param>
        public static void WriteIndented(bool message)
        {
            WriteLine($"\t{message}");
        }
    }
}
