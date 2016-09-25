using System;
using System.Threading.Tasks;

namespace Octo.Core.Parsers
{
    public class GenericParser
    {
        public async Task<ScrapingResult> BeginScrapeAsync()
        {
            return await Task.Run(() => {
                return new ScrapingResult("LAX", "NYC", new System.DateTime(2016, 12, 12), "");
            });
        }

        public async Task<ParseResult> Parse()
        {
            return await Task.Run(() => {
                return new ParseResult("LAX", "NYC", new System.DateTime(2016, 12, 12), 100m);
            });
        }
    }

    public class ScrapingResult
    {
        public ScrapingResult(string from, string to, DateTime when, string data)
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

    public class ParseResult
    {
        public ParseResult(string from, string to, DateTime when, decimal price)
        {
            From = from;
            To = to;
            When = when;
            Price = price;
        }

        public string From { get; private set; }
        public string To { get; private set; }
        public DateTime When { get; private set; }
        public Decimal Price { get; private set; }
    }
}
