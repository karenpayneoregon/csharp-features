using System;
using System.Drawing;

namespace ConsoleHelpers
{
    public class ConsoleRectangle
    {
        private Point _hLocation;

        private readonly string _text;

        public ConsoleRectangle(
            string text,
            int width,
            int height,
            Point location,
            ConsoleColor borderColor = ConsoleColor.Blue,
            ConsoleColor backColor = ConsoleColor.Blue,
            ConsoleColor foreBackgroundColor = ConsoleColor.White)
        {
            Width = width;
            Height = height;
            _hLocation = location;
            BorderColor = borderColor;
            BackgroundColor = backColor;
            ForegroundColor = foreBackgroundColor;

            _text = text;

        }

        public Point Location
        {
            get => _hLocation;
            set => _hLocation = value;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public ConsoleColor BorderColor { get; set; }

        public ConsoleColor BackgroundColor { get; set; }

        public ConsoleColor ForegroundColor { get; set; }

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

            Console.BackgroundColor = BackgroundColor;
            Console.CursorTop = _hLocation.Y;
            Console.CursorLeft = _hLocation.X;
            Console.Write(border);
            Console.ResetColor();
            Console.CursorTop = 1;
            Console.CursorLeft = 3;

            Console.BackgroundColor = BorderColor;
            Console.ForegroundColor = ForegroundColor;
            Console.WriteLine(_text);
            Console.ResetColor();

            Console.CursorTop = 4;
            Console.CursorLeft = 0;

        }
    }
}