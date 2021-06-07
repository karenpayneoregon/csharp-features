using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileLibrary;

namespace FileLibraryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Debug.WriteLine(Operations.UniqueFileName);
            //Debug.WriteLine(Operations.GenerateFileName());
            //Debug.WriteLine(Operations.GetTempFileName(null));

            //for (int index = 0; index < 20; index++)
            //{
            //    Debug.WriteLine($"{index +1, 3} {Incrementer.Instance.GetReferenceValue()}");
            //}

            //for (int index = 0; index < 10; index++)
            //{

            //    File.WriteAllText(Operations.NextFileName(), "");
            //}

            Operations.RemoveAllRecoveryFiles();

            if (Operations.HasAnyRecoveryFiles())
            {
                var lastFileName = Operations.GetLast();
            }
           


        }
    }
}
