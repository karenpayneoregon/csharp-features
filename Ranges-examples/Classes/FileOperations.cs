using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranges_examples.Classes
{
    public class FileOperations
    {
        public static string[] OregonCities() => File.ReadAllLines("OregonCityNames.txt");

    }
}
