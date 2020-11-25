using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using ExtensionsLibrary;
using Ranges_examples.Classes;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace Ranges_examples
{
    class Program
    {
        private static string _text;
        private static string _title;

        /// <summary>
        /// Index Operator ^
        /// Range Operator ..
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            _text = "Range example for C# 8\nPress any key to run.";
            _title = "Code samples";
            PanelBorders();
            Console.ReadLine();
            Ranges();

            Console.ReadLine();
        }



        private static void Ranges()
        {

            static void DisplayText(string text)
            {
                HorizontalRule(text);
            }

            var contacts = MockedData.ReadContacts();
            contacts = contacts.OrderBy(contact => contact.LastName).ToList();
            DisplayText("Basic");
            /*
             * Conventional for-next
             */
            for (int index = 0; index < contacts.Count; index++)
            {
                Console.WriteLine(contacts[index]);
            }

            DisplayText("Indexer version") ;


            /*
             * for-each doing entire list
             */
            foreach (var singleContact in contacts.ToArray()[..])
            {
                Console.WriteLine(singleContact);
            }

            DisplayText("Indexer version - skip first contact hard coded");

            /*
             * Skip first contact hard coding start index
             */
            foreach (var singleContact in contacts.ToArray()[1..])
            {
                Console.WriteLine(singleContact);
            }

            DisplayText("Indexer version - skip first contact dynamic");

            /*
             * Skip first contact dynamic start index
             */
            var startIndexer = new Index(1);
            foreach (var singleContact in contacts.ToArray()[startIndexer..])
            {
                Console.WriteLine(singleContact);
            }


            DisplayText("Indexer version - skip IndexOf 'Helen Bennett' iterate all past her");

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

            DisplayText("Indexer version - skip IndexOf 'Helen Bennett' iterate all past her 3");

            var endIndexer = new Index(findIndex +4);

            var afterHelen2 = contacts.ToArray()[startIndexer..endIndexer];
            /*
             * Find Helen Bennett, jump ahead one, iterate three contacts
             */
            foreach (var singleContact in afterHelen2)
            {
                Console.WriteLine(singleContact);
            }

            DisplayText("From Wang to end");

            findIndex = contacts.FindIndex(con => con.LastName == "Wang");
            var lastFiveContacts = contacts.ToArray()[findIndex..^0];

            foreach (var singleContact in lastFiveContacts)
            {
                Console.WriteLine(singleContact);
            }

            _text = "Press any key to leave";
            _title = "Done";
            PanelBorders();

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
        #region screen formatting

        private static void HorizontalRule(string title)
        {
            AnsiConsole.WriteLine();
            AnsiConsole.Render(new Rule($"[white bold]{title}[/]").RuleStyle("grey").LeftAligned());
            AnsiConsole.WriteLine();
        }
        private static void PanelBorders()
        {
            static IRenderable CreatePanel(string name, BoxBorder border)
            {
                return new Panel(_text)
                    .Header($" [yellow]{name}[/] ", Justify.Center)
                    .Border(border)
                    .BorderStyle(Style.Parse("grey"));
            }

            var items = new[]
            {
                CreatePanel(_title, BoxBorder.Square)

            };

            AnsiConsole.Render(
                new Padder(
                    new Columns(items).PadRight(2),
                    new Padding(2, 0, 0, 0)));
        }

        #endregion
    }
}
