using System.Collections.Generic;
using System.Globalization;

namespace ExceptionHandling
{
    public class LogContainer
    {
        public LoggerEntry LoggerEntry { get; set; }
        public List<string> Lines { get; set; }

        public LogContainer()
        {
            Lines = new List<string>();
        }
        public string[] ItemArray => new[]
        {
            LoggerEntry.LogLevel.ToString(), 
            LoggerEntry.DateTimeStamp.ToString(CultureInfo.InvariantCulture)
        };
    }
}