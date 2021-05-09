using System;
using System.Drawing;

namespace ConsoleHelpers
{
    /// <summary>
    /// Helper to create colored boxes
    /// </summary>
    public class ConsoleRectangle
    {
        private int _hWidth;
        private int _hHeight;
        private Point _hLocation;
        private ConsoleColor _hBorderColor;
        private string _text;
        /// <summary>
        /// Create Rectangle with border color color
        /// </summary>
        /// <param name="width">width of Rectangle</param>
        /// <param name="height">height of Rectangle</param>
        /// <param name="location">location of Rectangle</param>
        /// <param name="borderColor">Rectangle border color</param>
        /// <param name="text">Text to display</param>
        public ConsoleRectangle(int width, int height, Point location, ConsoleColor borderColor, string text)
        {
            _hWidth = width;
            _hHeight = height;
            _hLocation = location;
            _hBorderColor = borderColor;
            _text = text;
        }

        /// <summary>
        /// Location
        /// </summary>
        public Point Location
        {
            get => _hLocation;
            set => _hLocation = value;
        }
        /// <summary>
        /// Width
        /// </summary>
        public int Width
        {
            get => _hWidth;
            set => _hWidth = value;
        }
        /// <summary>
        /// Height
        /// </summary>
        public int Height
        {
            get => _hHeight;
            set => _hHeight = value;
        }
        /// <summary>
        /// Border color
        /// </summary>
        public ConsoleColor BorderColor
        {
            get => _hBorderColor;
            set => _hBorderColor = value;
        }
        /// <summary>
        /// Draw box
        /// </summary>
        public void Draw()
        {
            string border = "╔";
            string space = "";
            string temp = "";
            
            for (int index = 0; index < Width; index++)
            {
                space += " ";
                border += "═";
            }

            for (int j = 0; j < Location.X; j++)
            {
                temp += " ";
            }

            border += "╗" + "\n";

            for (int index = 0; index < Height; index++)
            {
                border += temp + "║" + space + "║" + "\n";
            }

            border += temp + "╚";
            
            for (int index = 0; index < Width; index++)
            {
                border += "═";
            }

            border += "╝" + "\n";

            Console.ForegroundColor = BorderColor;
            Console.CursorTop = _hLocation.Y;
            Console.CursorLeft = _hLocation.X;
            Console.Write(border);
            Console.ResetColor();
            Console.CursorTop = 1;
            Console.CursorLeft = 3;

            Console.WriteLine(_text);

            Console.CursorTop = 4;
            Console.CursorLeft = 0;

        }
    }
}
