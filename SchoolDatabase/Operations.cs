using System;
using System.Linq;
using EntityCoreExtensions;
using SchoolDatabase.Data;
using SchoolDatabase.Models;

namespace SchoolDatabase
{
    public class Operations
    {
        public static void TestReset()
        {
            using var context = new SchoolContext();
            
            var firstPerson = context.Person.FirstOrDefault();
            Console.WriteLine();


            firstPerson.FirstName = "Dan";

            context.Reset();
            Console.WriteLine(firstPerson.FirstName);

            context.Remove(firstPerson);
            context.Reset();
            Console.WriteLine($"After delete state {context.Entry(firstPerson).State}");
            
            var newPerson = new Person() {FirstName = "Karen"};
            context.Add(newPerson);
            context.Reset();
            Console.WriteLine($"new person state {context.Entry(newPerson).State}");
            
            Console.WriteLine(context.ChangeTracker.HasChanges());

            Console.ReadLine();

        }
    }
}
