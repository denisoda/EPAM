using System.Text.RegularExpressions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BLL.classes
{
    public class UrlService
    {
        private Uri uri;

        public string GetDomain(string url)
        {
            uri = new Uri(url);
            
            return uri.Host;
        }

        public string GetSegment(string url)
        {
            uri = new Uri(url);
            
            return uri.Segments[1];
        }
        public string GetQuery(string url)
        {
            uri = new Uri(url);
            
            return uri.Query;
        }
    }
}