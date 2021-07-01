using System.IO;

namespace GetStackTrace
{
    public class FileOperations
    {
        public static void CauseError1()
        {
            var results = File.ReadAllLines("SomeFile.kp");
        }

        public static void Step1()
        {
            Step2();
        }

        public static void Step2()
        {
            var result = Directory.GetFiles("C:\\Karen");
        }
    }
}