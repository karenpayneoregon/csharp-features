using System;
using System.Diagnostics;
using System.IO;

namespace SwitchExpressions_basics.Classes
{
    public class ProcessCodeSample
    {
        private static readonly string BasePath = 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Processed");
        
        public static void ExpressionSwitch(string filename, string extension)
        {

            var process = new Process
            {
                StartInfo =
                {
                    FileName = extension switch
                    {
                        "docx" => "WINWORD.EXE",
                        "doc" => "WINWORD.EXE",
                        "xlsx" => "EXCEL.EXE",
                        "xls" => "EXCEL.EXE",
                        "pdf" => "AcroRd32.exe",
                        _ => throw new NotImplementedException("Unknown file type")
                    }
                }
            };


            if (!File.Exists(Path.Combine(BasePath, filename))) return;

            process.StartInfo.Arguments = Path.Combine(BasePath, filename);
            process.Start();

        }
        public static void SwitchConventional(string filename, string extension)
        {

            var process = new Process();

            switch (extension)
            {
                case "docx":
                case "doc":
                    process.StartInfo.FileName = "WINWORD.EXE";
                    break;
                case "xlsx":
                case "xls":
                    process.StartInfo.FileName = "EXCEL.EXE";
                    break;
                case "pdf":
                    process.StartInfo.FileName = "AcroRd32.exe";
                    break;
                default:
                    throw new NotImplementedException("Unknown file type");
            }

            if (!File.Exists(Path.Combine(BasePath, filename))) return;

            process.StartInfo.Arguments = Path.Combine(BasePath, filename);
            process.Start();

        }
    }
}
