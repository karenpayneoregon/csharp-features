using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace Sides_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DifferencesBetweenTextFiles();
            Console.ReadKey();
        }


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
