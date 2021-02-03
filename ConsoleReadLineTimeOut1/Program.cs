using System;
using System.IO;
using System.Text;
using static System.Console;
using static ConsoleReadLineTimeOut1.ConsoleHelpers;

namespace ConsoleReadLineTimeOut1
{
    class Program
    {
        static void Main(string[] args)
        {
            var paragraphs = Generator.LoremIpsum(2, 10, 10, 10, 10).Replace("</p>", "</p>\n");
            File.WriteAllText("c.txt", paragraphs);
        }


        static void Test()
        {
            DefaultTimeOut = 14;
            var dateTime = ReadLineIntTimeWait();
            if (dateTime.HasValue)
            {
                WriteLine($"{dateTime.Value:d}");
            }
            else
            {
                WriteLine("Null");
            }
            ReadLine();


            WriteLine("First name");
            Console.ReadLine();
            var firstName = ReadLineWaitFiveSeconds();
            WriteLine(string.IsNullOrWhiteSpace(firstName) ? "No first name" : $"First name: {firstName}");

            WriteLine("Last name");
            var lastName = ReadLineWaitFiveSeconds();
            WriteLine(string.IsNullOrWhiteSpace(lastName) ? "No last name" : $"Last name: {lastName}");

            WriteLine("Done");
            ReadLineWaitTenSeconds();
        }

        public class Generator
        {
            public static string LoremIpsum(int minWords, int maxWords, int minSentences, int maxSentences, int numParagraphs)
            {

                var words = new[]{"lorem", "ipsum", "dolor", "sit", "amet", "consectetuer",
                    "adipiscing", "elit", "sed", "diam", "nonummy", "nibh", "euismod",
                    "tincidunt", "ut", "laoreet", "dolore", "magna", "aliquam", "erat"};

                var rand = new Random();
                int numSentences = rand.Next(maxSentences - minSentences) + minSentences + 1;
                int numWords = rand.Next(maxWords - minWords) + minWords + 1;

                var sb = new StringBuilder();

                for (int positionIndex = 0; positionIndex < numParagraphs; positionIndex++)
                {
                    sb.Append("<p>");
                    for (int index = 0; index < numSentences; index++)
                    {
                        for (int wordIndex = 0; wordIndex < numWords; wordIndex++)
                        {
                            if (wordIndex > 0)
                            {
                                sb.Append(" ");
                            }
                            
                            sb.Append(words[rand.Next(words.Length)]);
                        }
                        sb.Append(". ");
                    }
                    sb.Append("</p>");
                }

                return sb.ToString();
            }
        }
    }
    
    
}
