using System;

namespace HoHoHo
{
    class Program
    {
        static void Main()
        {
            Random randomRow = new();
            
            int color, i = 0;
            int height = randomRow.Next(6, 22);

            int heightIncrement = height - 2;

            var colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            var colorNumber = colors.Length;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*".PadLeft(heightIncrement + 1));

            while (i <= heightIncrement)
            {
                color = randomRow.Next(0, colorNumber);
                Console.ForegroundColor = colors[color];
                Console.WriteLine(new string('^', i++ * 2 + 1).PadLeft(heightIncrement + i));
            }
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('|', 3).PadLeft(heightIncrement + 2));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Merry Christmas and Happy New Year!");

            Console.ReadLine();
        }


    }
}