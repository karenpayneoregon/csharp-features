using DeconstructPerson.Records;
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
}
