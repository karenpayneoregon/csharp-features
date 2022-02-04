using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Ranges_examples
{
    class Demos
    {
        /// <summary>
        /// Get work days via a range using indices
        /// </summary>
        private static void DayNamesIndexing()
        {
            var days = DateTimeFormatInfo.CurrentInfo?.DayNames;

            var workDays = days?[1..6];

            // Monday through Friday show day names
            foreach (var day in workDays)
            {
                Debug.WriteLine(day);
            }

            Debug.WriteLine("");

            // to visualize indices done above e.g. 0 is Sunday
            var indexed = days!
                .Select((name, index) => new
                {
                    Name = name,
                    Index = index
                });

            foreach (var dayItem in indexed)
            {
                Debug.WriteLine($"{dayItem.Index,-3}{dayItem.Name}");
            }


        }
    }
}
