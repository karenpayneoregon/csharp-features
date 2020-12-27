using System;

namespace Relational_Pattern_Matching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Need to select one of the examples");


            //Example1();
            //Example2();
            Example3();
        }

        /// <summary>
        /// 
        /// </summary>
        static void Example1()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter a int following by ENTER or press ENTER to exit.");
                var userValue = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userValue))
                {
                    return;
                }

                if (int.TryParse(userValue, out var result))
                {
                    /*
                     *  C# 9 has introduced the "is" and "and" keywords
                     */
                    if (result is > 0 and <= 10)
                    {
                        Console.WriteLine("More than 0 but less than or equal to 10");
                        Console.ReadLine();
                    }
                }
            }
        }
        /// <summary>
        /// Switch expression example
        /// </summary>
        static void Example2()
        {
            int[] values = new[] { -1, 10, 0, 11, 1 };

            foreach (var value in values)
            {
                Console.WriteLine($"{value,4} is {value.Determination()}");
            }

            Console.ReadLine();
        }

        static void Example3()
        {

            Console.WriteLine(2.Determination3());
            Console.ReadLine();

        }
    }
}
