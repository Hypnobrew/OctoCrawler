using System;

namespace Octo.Infrastructure.Messages
{
    public class BeginScraping
    {
        public BeginScraping(string url, string from, string to, DateTime when)
        {
            Url = url;
            From = from;
            To = to;
            When = when;
        }
        
        public string Url { get; private set; }
        public string From { get; private set; }
        public string To { get; private set; }
        public DateTime When { get; private set; }
    }
    
    public class BeginParsing
    {
        public BeginParsing(string from, string to, DateTime when, string data)
        {
            From = from;
            To = to;
            When = when;
            Data = data;
        }

        public string From { get; private set; }
        public string To { get; private set; }
        public DateTime When { get; private set; }
        public string Data { get; private set; }
    }
}
