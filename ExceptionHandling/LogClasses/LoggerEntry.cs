using System;
using ExceptionHandling.Interfaces;

namespace ExceptionHandling.LogClasses
{
    
    public class LoggerEntry
    {
        public int LineNumber { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public LogLevel LogLevel { get; set; }
    }
}
