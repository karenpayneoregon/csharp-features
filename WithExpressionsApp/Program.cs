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
            
            var person = Mocked.People().FirstOrDefault(peep => peep.FirstName == "Karen");

            
            WriteSectionBold("Founded", false);

            WriteIndented(person?.ToString());
            
            EmptyLine();
            
            
            if (person is not null)
            {
                var otherPerson = person with { LastName = "Black" };

                WriteSectionBold("using with",false);

                WriteIndented(otherPerson.ToString());
            }

            Console.ReadLine();
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

            peopleList.Add(new Person() { FirstName = "Bob", LastName = "Jones"});
            peopleList.Add(new Person() { FirstName = "Karen", LastName = "Smith"});

            return peopleList;

        }

    }
}
