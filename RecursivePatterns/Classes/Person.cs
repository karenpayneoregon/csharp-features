using System;

namespace RecursivePatterns.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public override string ToString() => $"{Id} {FullName}";
    }
}
