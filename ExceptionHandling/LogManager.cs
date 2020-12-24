using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionHandling.Interfaces;

namespace ExceptionHandling
{
    /// <summary>
    /// Simple no frills logger to avoid a 3rd party package
    /// </summary>
    public class LogManager : ILogger
    {
        /// <summary>
        /// File name to write information into
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Create or append level and message along with date-time stamp
        /// </summary>
        /// <param name="level">Type</param>
        /// <param name="message">Text to write</param>
        public void Log(LogLevel level, string message)
        {
            if (string.IsNullOrWhiteSpace(FileName))
            {
                FileName = "ApplicationLog.csv";
            }
            
            try
            {
                if (File.Exists(FileName))
                {
                    var contents = File.ReadAllLines(FileName).ToList();
                    contents.Add($"{DateTime.Now},{level},{message}");
                    File.WriteAllLines(FileName, contents.ToArray());
                }
                else
                {
                    File.WriteAllText(FileName, $"{DateTime.Now},{level},{message}");
                }
            }
            catch (Exception e)
            {
                Exceptions.Write(e);
            }
        }
    }
}
