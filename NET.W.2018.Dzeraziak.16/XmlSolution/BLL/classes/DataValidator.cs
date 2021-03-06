using System;
using System.Text.RegularExpressions;
using NLog;

namespace BLL.classes
{
    public static class DataValidator 
    {
        private static string htmlRegexPattern = @"(^((http[s]?|ftp):\/)?\/?([^:\/\s]+)((\/\w+)*\/)([\w\-\.]+[^#?\s]+)(.*)?(#[\w\-]+)?$)*";

        public static bool IsValidUrl(string data)
        {
            if(data == null)
                throw new ArgumentNullException("data is null");

            return Regex.IsMatch(data, htmlRegexPattern);
        } 
    }
}