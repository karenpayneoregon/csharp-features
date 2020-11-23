using System;
using System.Collections.Generic;
using NewExpressions.Classes;

namespace NewExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * new expression or target typing
             */
            List<Person> people = new();

            foreach (var person in Mocked.PeopleList())
            {
                people.Add(person);
            }

            Console.WriteLine("People:");

            foreach (var person in people)
            {
                ConsoleWriter.WriteConsoleColorNewLine(
                    new ColoredString(ConsoleColor.White, $"{person.Id} "), 
                    new ColoredString(ConsoleColor.Yellow, $"{person.FullName}"),
                    new ColoredString(ConsoleColor.Red, $"{(person is Manager ? " manager" : " employee")}"));
            }

            Console.ReadLine();
        }
    }
}
