using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppWriteToFile
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            await FileOperations.Write("SomeFile.txt", "Line 1\nline2");

            FileOperations.GetDesktopFiles();
            
        }
    }
    
    

    public class FileOperations
    {
        public static async Task Write(string fileName, string content)
        {
            await File.WriteAllTextAsync(fileName, content);
        }

        public static void GetDesktopFiles()
        {
            var list = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)).GetFiles().Concat(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory)).GetFiles()).Distinct();

            foreach (var file in list)
            {
                Debug.WriteLine(file.Name);
            }
        }
    }
}
