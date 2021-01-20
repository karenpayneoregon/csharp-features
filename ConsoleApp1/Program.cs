using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = Mocked().GroupBy(person => person.Customer) 
                .OrderByDescending(group => group.Max(person => person.Total))
                .Select(group => group.OrderBy(person => person.Total))
                .Select((people,index) => new {RowIndex = index +1, item = people}).ToList();

            foreach (var result in results)
            {
                Console.WriteLine($"{result.RowIndex}, {result.item.LastOrDefault()}");
            }


            Console.ReadLine();
        }

        static List<Person> Mocked()
        {
            var list = new List<Person>
            {
                new() {Id = 1, Customer = "Sally", Total = 1},
                new() {Id = 2, Customer = "Joe", Total = 2},
                new() {Id = 3, Customer = "Bill", Total = 5},
                new() {Id = 4, Customer = "Sally", Total = 3},
                new() {Id = 5, Customer = "Joe", Total = 6}
            };

            return list;
        }
    }

   
    public class Person
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public int Total { get; set; }
        public override string ToString()
        {
            return $"{Customer},{Total}";
        }
    }
}
