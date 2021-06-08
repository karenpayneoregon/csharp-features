using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace IterateTwoList
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareVersions();
        }

        private static void CompareVersions()
        {
            var uri = "https://pastebin.com/raw/Ujy28wcb";
            var webClient = new WebClient();
            var content = webClient.DownloadString(uri);
            var expectedVersion = new Version("1.0.1");

            var version = new Version(content);

            if (version != expectedVersion)
            {
                Debug.WriteLine($"{content} is not {expectedVersion}");
            }
            else
            {
                Debug.WriteLine($"Yes {content} matches {expectedVersion}");
            }
        }

        private static void Example1()
        {
            var list1 = new List<double>() {1.1, 1.2, 1.3};
            var list2 = new List<double>() {2.1, 2.2, 2.3};

            var result = list1.Zip(list2, (value1, value2) => new
            {
                Value1 = value1, 
                Value2 = value2
            });
            
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Value1} - {item.Value2}");
            }

            Console.WriteLine();
            
            using var enumerator1 = list1.GetEnumerator();
            using var enumerator2 = list2.GetEnumerator();
            
            while (enumerator1.MoveNext() && enumerator2.MoveNext())
            {
                var value1 = enumerator1.Current;
                var value2 = enumerator2.Current;
                Console.WriteLine($"{value1} - {value2}");
            }
        }
        /// <summary>
        /// Different size list so in this case iteration stops on C.
        /// </summary>
        private static void Example2()
        {
            var list1 = new List<int>() { 1, 2, 3 };
            var list2 = new List<string>() { "A", "B", "C", "D", "E"};

            var result = list1.Zip(list2, (value1, value2) => new
            {
                Value1 = value1,
                Value2 = value2
            });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Value1} - {item.Value2}");
            }

            Console.WriteLine();

            using var enumerator1 = list1.GetEnumerator();
            using var enumerator2 = list2.GetEnumerator();

            while (enumerator1.MoveNext() && enumerator2.MoveNext())
            {
                var value1 = enumerator1.Current;
                var value2 = enumerator2.Current;
                Console.WriteLine($"{value1} - {value2}");
            }
        }
        private static void Example3()
        {
            var list1 = new List<double>() { 1.1, 1.2, 1.3 };
            var list2 = new List<double>() { 2.1, 2.2, 2.3 };

            var result = list1.Zip(list2, (value1, value2) => new
            {
                Value1 = value1,
                Value2 = value2
            });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Value1} - {item.Value2}");
                double fibo2 = item.Value1.DoSomething(item.Value2);
            }

            
        }
    }

    public static class Extensions
    {
        public static double DoSomething(this double value, double otherValue)
        {
            /*
             * Do calculations than return results
             */
            return 0; 
        }
    }

}
