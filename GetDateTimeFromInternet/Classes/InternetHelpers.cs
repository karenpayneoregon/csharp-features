using System;
using System.Globalization;
using System.Net;

namespace GetDateTimeFromInternet.Classes
{
    public class InternetHelpers
    {
        public static DateTimeOffset? LocalTime()
        {
            var result = GetCurrentTimeFromWeb();
            return result?.ToLocalTime();
        }
        public static DateTimeOffset? GetCurrentTimeFromWeb()
        {
            var sites = new[] { "https://nist.time.gov", "http://www.microsoft.com", "http://www.google.com" };

            foreach (var site in sites)
            {
                try
                {
                    var dateTimeOffset = GetTimeFromSite(site);
                    if (dateTimeOffset != null)
                    {
                        return dateTimeOffset;
                    }
                }
                catch
                {
                    continue;
                }
            }
            
            return null;
            
        }

        private static DateTimeOffset? GetTimeFromSite(string site)
        {
            var request = WebRequest.Create(site);
            var response = request.GetResponse();
            
            string currentHeader = response.Headers["date"];
            
            var dateTimeOffset = DateTimeOffset.ParseExact(currentHeader, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", 
                CultureInfo.InvariantCulture.DateTimeFormat, 
                DateTimeStyles.AssumeUniversal);
            
            return dateTimeOffset;
        }
    }
}
