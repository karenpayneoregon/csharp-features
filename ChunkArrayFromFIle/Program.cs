using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Channels;

namespace ChunkArrayFromFIle
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleList = FileOperations.Read();

            var person = peopleList.FirstOrDefault(p => p.FirstName == "Roberto" && p.LastName == "Tamburello");
            if (person is not null)
            {
                person.Phone = "303-555-0187";
            }

            FileOperations.Write(peopleList);

        }
    }

    public class FileOperations
    {
        public static string _fileName = "people.txt";
        /// <summary>
        /// Write people back to same file as read from
        /// </summary>
        /// <param name="peopleList">valid list of <seealso cref="Person"/></param>
        public static void Write(List<Person> peopleList)
        {
            File.WriteAllLines(_fileName, peopleList
                .Select(person => person.Contents)
                .ToArray());
            
        }

        /// <summary>
        /// Assumes file exists and there are three line per person
        ///
        /// chunks array uses index in the select although never used
        /// Index could be used as a primary key
        /// </summary>
        /// <returns>List of <see cref="Person"/></returns>
        public static List<Person> Read()
        {
            const int chunkSize = 3;
            var contents = File.ReadAllLines(_fileName);

            string[][] chunks = contents
                .Select((line, index) => new {Line = line, Index = index})
                .GroupBy(anonymous => anonymous.Index / chunkSize)
                .Select(grp => grp.Select(anonymous => anonymous.Line).ToArray())
                .ToArray();

            return chunks.Select(item => new Person()
            {
                FirstName = item[0], 
                LastName = item[1], 
                Phone = item[2]
            }).ToList();
            
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Contents => $"{FirstName}\n{LastName}\n{Phone}";
        public override string ToString() => $"{FirstName} {LastName} {Phone}";

    }
}
