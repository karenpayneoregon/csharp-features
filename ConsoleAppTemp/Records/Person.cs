namespace DeconstructPerson.Records
{
    public record Person
    {
        
        public string LastName { get; }
        public string FirstName { get; }

        public Person(string first, string last) => (FirstName, LastName) = (first, last);
        public void Deconstruct(out string firstName, out string lastName) => (firstName, lastName) = (FirstName, LastName);
        
    }
}