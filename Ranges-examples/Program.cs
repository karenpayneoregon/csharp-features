using System;
using System.Globalization;
using System.IO;
using System.Reflection.Emit;
using ExtensionsLibrary;

namespace Ranges_examples
{
    class Program
    {
        /// <summary>
        /// https://www.telerik.com/blogs/c-8-indices-and-range
        ///
        /// Index Operator ^
        /// Range Operator ..
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Basic1();

            //Basic2();
            //SignCheck();

            Console.ReadLine();
        }
        /// <summary>
        /// Indexer sub string from start of string
        /// </summary>
        private static void Basic1()
        {
            var sentence = "Just want to say, Hello World there!";
            if (!sentence.ContainsIgnoreCase("world")) return;

            Index indexStart = sentence.IndexOf("world", StringComparison.InvariantCultureIgnoreCase) -1;
            Console.WriteLine($"{sentence[0..indexStart]} to you!!!");

        }
        /// <summary>
        /// Indexer to get sub string from end of string
        /// </summary>
        private static void Basic2()
        {
            var fileName = "myTestFileName.txt123";
            var index = (fileName.LastIndexOf(".", StringComparison.Ordinal) - fileName.Length);

            if (index.IsNegative())
            {
                index = index.Invert();
            }

            var indexFromEnd = new Index(index, true);
            var extension = fileName[indexFromEnd..^0];
            Console.WriteLine(extension);

            /*
             * Of course
             */
            Console.WriteLine(Path.GetExtension(fileName));
        }

        #region side examples
        static void SignCheck()
        {
            NegativeOrPositiveDecimal();
            Console.WriteLine();
            NegativeOrPositiveInt();
        }

        static void NegativeOrPositiveDecimal()
        {
            Console.WriteLine("decimal, is negative or positive");
            decimal decimalItem = -1.3m;
            Console.WriteLine($"{nameof(decimalItem)} : [{decimalItem}] is negative? {decimalItem.IsNegative()}");

            decimalItem = 1.2m;
            Console.WriteLine($"{nameof(decimalItem)} : [{decimalItem}] is positive? {decimalItem.IsPositive()}");
        }
        static void NegativeOrPositiveInt()
        {
            Console.WriteLine("int, is negative or positive");
            int intItem = -1;
            Console.WriteLine($"{nameof(intItem)} : [{intItem}] is negative? {intItem.IsNegative()}");

            intItem = 1;
            Console.WriteLine($"{nameof(intItem)} : [{intItem}] is positive? {intItem.IsPositive()}");
        }
        #endregion
    }
}
