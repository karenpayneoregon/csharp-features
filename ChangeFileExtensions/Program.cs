using System;

namespace ChangeFileExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            //RenameExtensions(AppDomain.CurrentDomain.BaseDirectory, "text", "txt");


            Nullable<DateTime> TravelTime = null;
            Console.WriteLine(DateHelpers.RouteCheck(ref TravelTime));

            

            TravelTime = DateTime.Now;
            Console.WriteLine(DateHelpers.RouteCheck(ref TravelTime));

            string someDate = "01/01/2021 09:00:00";

            if (someDate.Is<DateTime>())
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }

            var test = DateHelpers.TryParseDateTime(someDate);
            if (test.HasValue)
            {
                Console.WriteLine(DateHelpers.RouteCheck(ref TravelTime));
            }
            else
            {
                Console.WriteLine("Not a date time");
            }


            
            someDate = "";

            if (someDate.Is<DateTime>())
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }



            test = DateHelpers.TryParseDateTime(someDate);
            if (test.HasValue)
            {
                Console.WriteLine(DateHelpers.RouteCheck(ref TravelTime));
            }
            else
            {
                Console.WriteLine("Not a date time");
            }
            
            Console.ReadLine();
        }
    }
}
