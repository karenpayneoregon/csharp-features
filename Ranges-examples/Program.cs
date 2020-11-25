using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using ExtensionsLibrary;
using Ranges_examples.Classes;

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
            Ranges();
            Console.ReadLine();
        }

        private static void Ranges()
        {

            var originalForeColor = Console.ForegroundColor;

            static void DisplayText(string text, ConsoleColor originalForeColor)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(text);
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = originalForeColor;
            }

            var contacts = MockedData.ReadContacts();
            contacts = contacts.OrderBy(contact => contact.LastName).ToList();

            /*
             * Conventional for-next
             */
            for (int index = 0; index < contacts.Count; index++)
            {
                Console.WriteLine(contacts[index]);
            }

            DisplayText("Ready for indexer version", originalForeColor) ;


            /*
             * for-each doing entire list
             */
            foreach (var singleContact in contacts.ToArray()[..])
            {
                Console.WriteLine(singleContact);
            }

            DisplayText("Ready for indexer version - skip first contact hard coded", originalForeColor);

            /*
             * Skip first contact hard coding start index
             */
            foreach (var singleContact in contacts.ToArray()[1..])
            {
                Console.WriteLine(singleContact);
            }

            DisplayText("Ready for indexer version - skip first contact dynamic", originalForeColor);

            /*
             * Skip first contact dynamic start index
             */
            var startIndexer = new Index(1);
            foreach (var singleContact in contacts.ToArray()[startIndexer..])
            {
                Console.WriteLine(singleContact);
            }


            DisplayText("Ready for indexer version - skip IndexOf 'Helen Bennett' iterate all past her", originalForeColor);

            /*
             * Find Helen Bennett, jump ahead one, iterate to end
             */
            var findIndex = contacts.FindIndex( con => con.LastName == "Bennett");
            if (findIndex > -1)
            {
                startIndexer = new Index(findIndex +1);
            }

            var afterHelen1 = contacts.ToArray()[startIndexer..];
            foreach (var singleContact in afterHelen1)
            {
                Console.WriteLine(singleContact);
            }

            DisplayText("Ready for indexer version - skip IndexOf 'Helen Bennett' iterate all past her 3", originalForeColor);

            var endIndexer = new Index(findIndex +4);

            var afterHelen2 = contacts.ToArray()[startIndexer..endIndexer];
            /*
             * Find Helen Bennett, jump ahead one, iterate three contacts
             */
            foreach (var singleContact in afterHelen2)
            {
                Console.WriteLine(singleContact);
            }

            DisplayText("From Wang to end", originalForeColor);

            findIndex = contacts.FindIndex(con => con.LastName == "Wang");
            var lastFiveContacts = contacts.ToArray()[findIndex..^0];

            foreach (var singleContact in lastFiveContacts)
            {
                Console.WriteLine(singleContact);
            }

            DisplayText("Done", originalForeColor);
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
