using static System.Console;

namespace DeconstructPerson
{
    class Program
    {
        private static void Main()
        {
            ShowRecordDeconstruction();

            _ = ReadKey();
        }

        private static void ShowRecordDeconstruction()
        {
            var person = new Person("Karen", "Payne");

            var (first, last) = person;
            
            WriteLine(first);
            WriteLine(last);
            
        }
    }

    public record Person
    {
        
        public string LastName { get; }
        public string FirstName { get; }

        public Person(string first, string last) => (FirstName, LastName) = (first, last);
        public void Deconstruct(out string firstName, out string lastName) => (firstName, lastName) = (FirstName, LastName);
        
    } 
}
