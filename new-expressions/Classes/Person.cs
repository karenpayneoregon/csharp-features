using System;
using NewExpressions.Interfaces;

namespace NewExpressions.Classes
{
    public class Person : IPerson
    {
        public Person()
        {
            
        }

        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = LastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public override string ToString() => $"{Id} {FullName}";
    }
}
