using System;
using System.IO;
using System.Linq;

namespace Sides_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DifferencesBetweenTextFiles();
            Console.ReadKey();
        }

        /// <summary>
        /// Get differences between two list read from two text files
        /// in search of one or more items that is different between the two list.
        /// </summary>
        private static void DifferencesBetweenTextFiles()
        {
            const string folderName = "C:\\OED\\Documents\\Pulls";
            
            var foundList = File.ReadAllLines("Email.txt")
                .ToList()
                .Except(File.ReadAllLines("Excel.txt").ToList())
                .ToList();

            if (foundList.Count <= 0) return;
            
            foreach (var fileName in foundList
                .Select(guid => Directory.GetFiles(folderName, $"{guid}*.pdf"))
                .SelectMany(result => result)) { Console.WriteLine(fileName); }



        }

    }
}
