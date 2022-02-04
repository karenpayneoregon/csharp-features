using System;
using System.Collections.Generic;
using System.Linq;
using static ConsoleHelpers.ConsoleColors;

namespace WithExpressionsApp
{
#nullable enable

    /// <summary>
    /// https://devblogs.microsoft.com/dotnet/c-9-0-on-the-record/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            WriteHeader("with expressions");

            Person? person = Mocked.People().FirstOrDefault(peep => peep.FirstName == "Karen");


            WriteSectionBold("Founded", false);

            WriteIndented(person?.ToString());

            EmptyLine();


            if (person is not null)
            {
                Person? otherPerson = person with { LastName = "Black" };

                WriteSectionBold("using with", false);

                WriteIndented(otherPerson.ToString());
            }

            Console.ReadLine();
        }


    }

        public class AutoDisposeList1<T> : List<T>, IDisposable where T : IDisposable
        {
            public void Dispose()
            {
                foreach (var obj in this)
                {
                    obj.Dispose();
                }
            }
        }



    public record Person
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    class Mocked
    {
        public static List<Person> People()
        {
            List<Person> peopleList = new();

            peopleList.Add(new Person() { FirstName = "Bob", LastName = "Jones" });
            peopleList.Add(new Person() { FirstName = "Karen", LastName = "Smith" });

            return peopleList;

        }


    }


    class Mocked1
    {
        public static List<Person> People() =>
            new()
            {
                new() { FirstName = "Bob", LastName = "Jones" },
                new() { FirstName = "Karen", LastName = "Smith" }
            };
    }
    class Mocked3
    {
        public static List<Person> People() =>
            new List<Person>()
            {
                new Person() { FirstName = "Bob", LastName = "Jones" },
                new Person() { FirstName = "Karen", LastName = "Smith" }
            };
    }
}
