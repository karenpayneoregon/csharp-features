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
            //GenericDemo1();
            //_text = "Range example for C# 8\nPress any key to run.";
            //_title = "Code samples";
            //PanelBorders();
            //Console.ReadLine();
            //Ranges();

            //int[] numberIntegers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach (var index in numberIntegers[..]) // all
            //{
            //    Debug.Write(index); // 0123456789
            //}

            //Debug.WriteLine("");
            //foreach (var integer in numberIntegers)
            //{
            //    Debug.Write(integer);
            //}

            //BasicRangeIndices.Examples();
            //WithString();
            //BetweenItems();



            //Creating1();

            //BetweenInts();

            BetweenStringItems();


            Console.ReadLine();
            
        }

        private static void BetweenInts()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            var items = list.BetweenItems(2, 4);
            foreach (var item in items)
            {
                Debug.WriteLine(item);
            }

        }
        private static void WithString()
        {
            var someText = "ABCDEFG";

            var substring = someText.SubstringByIndexes(1, 3);
            Console.WriteLine(substring);

            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            //var shortRange = list.GetRange(1, 3);
            //Console.WriteLine(string.Join(",", list.ToArray()));

            var startIndex = list.Find(x => x == 2);
            var endIndex = startIndex + 3;
            //var range = (new Index(find),new Index(2 - find,true));


            if (endIndex <= list.Count)
            {
                var array1 = list.ToArray()[startIndex..endIndex];
                Console.WriteLine(string.Join(",", array1));
            }
            else
            {
                Console.WriteLine("out of range");
            }

        }

        /// <summary>
        /// public static int GetCityIndex(string cityName) => SomeOregonCities.ToList().IndexOf(cityName);
        /// </summary>
        private static void Creating()
        {
            string startCity = "Aloha";
            string endCity = "Ashland";
            string[] oregonCities = FileOperations.OregonCities();

            List<int> rangeReverse = Enumerable.Range(0, oregonCities.Length).Reverse().ToList();

            List<City> cities = oregonCities.Select(
                (cityName, index) => new City()
                {
                    Name = cityName,
                    StartIndex = new Index(index),
                    EndIndex = new Index(rangeReverse[index], true)
                }).ToList();


            var (startIndex1, endIndex1) = cities.BetweenTwo("Aloha", "Ashland");

            var citiesBetweenTwoCities = oregonCities[startIndex1..endIndex1];

            foreach (var item in citiesBetweenTwoCities)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        private static void Creating1()
        {
            string startCity = "Aloha";
            string endCity = "Ashland";

            var cities = Helpers.GetBetweenInclusive(FileOperations.OregonCities(), startCity, endCity);

            if (cities is not null)
            {
                foreach (var result in cities)
                {
                    Debug.WriteLine(result);
                }
            }
            else
            {
                Debug.WriteLine("Operation failed");
            }


        }

        private static void BetweenStringItems()
        {
            List<string> periods = new List<string>
            {
                "2010 Fya",
                "2011 FYA",
                "2012 FYA",
                "2013 FYA",
                "1Q 2014A",
                "2Q 2014A",
                "3Q 2014A",
                "4Q 2014A",
                "2014 FYA"
            };


            var result = periods.BetweenItems("2010 FYA", "3Q 2014A");
            if (result is not null)
            {
                foreach (var item in result)
                {
                    Debug.WriteLine(item);
                }
            }
            else
            {
                Debug.WriteLine("Start or end value not located");
            }
        }


        private static string[] SomeOregonCities =>
            new[]
            {
                //              index from start    index from end                
                "Adams",        // 0                ^10
                "Albany",       // 1                ^9
                "Aloha",        // 2                ^8
                "Arlington",    // 3                ^7
                "Ashland",      // 4                ^6
                "Astoria",      // 5                ^5
                "Burns",        // 6                ^4
                "Jacksonville", // 7                ^3
                "Salem",        // 8                ^2
                "Portland",     // 9                ^1
                "Bend"          // 10               ^0 (or array length)
            };

        private static void Ranges()
        {
            /*
             * Static local function which is only callable in Ranges().
             */
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

            DisplayText("Indexer version");


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
            var findIndex = contacts.FindIndex(con => con.LastName == "Bennett");
            if (findIndex > -1)
            {
                startIndexer = new Index(findIndex + 1);
            }

            var afterHelen1 = contacts.ToArray()[startIndexer..];
            foreach (var singleContact in afterHelen1)
            {
                Console.WriteLine(singleContact);
            }

            DisplayText("Indexer version - skip IndexOf 'Helen Bennett' iterate all past her 3");

            var endIndexer = new Index(findIndex + 4);

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

        private static void GenericDemo1()
        {
            object[] sampleArray = { "Hello", "C#", true, 11, DateTime.Now };

            foreach (var o in sampleArray)
            {
                switch (o)
                {
                    case string:
                        Debug.WriteLine($"string: {o.ToString()}");
                        break;
                    case int i:
                        Debug.WriteLine($"o as in {i}");
                        break;
                    case bool b:
                        Debug.WriteLine($"o is bool {b}");
                        break;
                    default:
                        Debug.WriteLine($"o is {o.GetType()}");
                        break;
                }
            }
        }

        private static void GenericDemo2()
        {
            object[] sampleArray = { "Hello", "C#", true, 11, DateTime.Now };

            foreach (var o in sampleArray)
            {
                switch (o)
                {
                    case string:
                        Debug.WriteLine($"string: {o.ToString()}");
                        break;
                    case int i:
                        Debug.WriteLine($"o as in {i}");
                        break;
                    case bool b:
                        Debug.WriteLine($"o is bool {b}");
                        break;
                    default:
                        Debug.WriteLine($"o is {o.GetType()}");
                        break;
                }
            }
        }
        private static void GenericDemo3()
        {
            object[] sampleArray = { "Hello", "C#", true, 11, DateTime.Now };

            foreach (var o in sampleArray)
            {
                switch (o)
                {
                    case string s:
                        Debug.WriteLine($"o is a string with value of {s}");
                        break;
                    case int i:
                        Debug.WriteLine($"o is a int with value of {i}");
                        break;
                    case bool b:
                        Debug.WriteLine($"Bool {b}");
                        break;
                    case DateTime d:
                        Debug.WriteLine($"DateTime: {d}");
                        break;
                }
            }
        }

        private static void GenericDemo4()
        {
            object[] sampleArray = { "Hello", "C#", true, 11, DateTime.Now };

            foreach (var currentElement in sampleArray)
            {
                switch (currentElement)
                {
                    case string stringValue:
                        Debug.WriteLine($"currentElement is a string with value of {stringValue}");
                        break;
                    case int intValue:
                        Debug.WriteLine($"currentElement is a int with value of {intValue}");
                        break;
                    case bool boolValue:
                        Debug.WriteLine($"currentElement is a bool with value of {boolValue}");
                        break;
                    case DateTime dateTimeValue:
                        Debug.WriteLine($"currentElement is a DateTime with value of: {dateTimeValue}");
                        break;
                }
            }
        }





        /// <summary>
        /// Indexer sub string from start of string
        /// </summary>
        private static void Basic1()
        {
            var sentence = "Just want to say, Hello World there!";
            if (!sentence.ContainsIgnoreCase("world")) return;

            Index indexStart = sentence.IndexOf("world", StringComparison.InvariantCultureIgnoreCase) - 1;
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
