using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButtonBinding.Classes
{
    public class DataOperations
    {
        private static string _fileName = "People.csv";

        /// <summary>
        /// Save all people back to the .csv file
        /// </summary>
        /// <param name="peopleList"></param>
        public static void SaveAll(List<Person> peopleList)
        {
            var sb = new StringBuilder();
            foreach (var person in peopleList)
            {
                sb.AppendLine(person.LineArray());
            }
            
            File.WriteAllText(_fileName, sb.ToString());
            
        }
        /// <summary>
        /// Read people from .csv file
        /// </summary>
        /// <returns>People list</returns>
        public static List<Person> ReadPeopleFromCommaDelimitedFile() =>
            File.ReadAllLines(_fileName).Select(content => content.Split(','))
                .Select(parts => new Person()
                {
                    Id = Convert.ToInt32(parts[0]),
                    FirstName = parts[1],
                    LastName = parts[2],
                    Gender = EnumConverter<GenderType>.Convert(Convert.ToInt32(parts[3])),
                    Suffix = EnumConverter<SuffixType>.Convert(Convert.ToInt32(parts[4]))
                })
                .ToList();

        
    }
}
