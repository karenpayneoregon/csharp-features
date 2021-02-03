using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using ExceptionHandling.Helpers;
using ExceptionHandling.Interfaces;

namespace ExceptionHandling.LogClasses
{
    public class LogReader
    {
        public delegate void OnEntryItemsAdded(LoggerEntry entry);
        public static event OnEntryItemsAdded OnEntryAddedEvent ;

        public delegate void OnEntryLineAdded(string line);

        public static event OnEntryLineAdded OnEntryLineAddedEvent;


        public static string FileName { get; set; } = "ApplicationLog.csv";
        internal static string[] TimeIndicators = { "AM,", "PM," };
        /// <summary>
        /// Read log file into a container along with optionally using
        /// events to get at details as read.
        /// </summary>
        /// <returns>List&lt;LogContainer&gt;</returns>
        public static List<LogContainer> Read()
        {
            List<LogContainer> logContainer = new();
            
            if (!File.Exists(FileName))
            {
                return logContainer;
            }
            
            /*
             * Read all line and assign line number to property using
             * an anonymous variable
             */
            var contents = File.ReadAllLines(FileName)
                .Select((line, index) => new {Line = line, Index = index +1})
                .ToList();

            foreach (var content in contents)
            {
                /*
                 * Check if the line is the first line for an exception
                 */
                if (TimeIndicators.Any(content.Line.Contains))
                {
                    
                    var parts = content.Line.Split(',');
                    
                    /*
                     * Get first date-time
                     */
                    var match = Regex.Match(content.Line, @"\b\d{1,2}/\d{1,2}/\d{4}\s\d{1,2}:\d{2}:\d{2}\s?[AP]M\b");
                    var dateValue = match.Value;
                    
                    /*
                     * Assert, the detail line has two elements, there is a valid date time
                     */
                    if (parts.Length == 2 && !string.IsNullOrWhiteSpace(dateValue) && DateTime.TryParse(dateValue, out var logDateTime))
                    {
                        /*
                         * Compose a LogEntry which where lines are assigned in the outer else
                         */
                        var item = new LoggerEntry()
                        {
                            LineNumber = content.Index,
                            DateTimeStamp = logDateTime,
                            LogLevel = parts[1].ToEnum(LogLevel.General)
                        };
                        
                        OnEntryAddedEvent?.Invoke(item);
                        logContainer.Add(new LogContainer() {LoggerEntry = item});
                    }
                }
                else
                {
                    OnEntryLineAddedEvent?.Invoke(content.Line);
                    logContainer.LastOrDefault()?.Lines.Add(content.Line);
                }
            }

            return logContainer;
        }
    }
}
