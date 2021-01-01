using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionHandling.Interfaces;

namespace ExceptionHandling
{
    
    public class LoggerEntry
    {
        public int LineNumber { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public LogLevel LogLevel { get; set; }
    }
}
