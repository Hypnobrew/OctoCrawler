using Akka.Actor;
using Octo.Core.Parsers;
using Octo.Infrastructure.Messages;

namespace Octo.Infrastructure.Actors
{
    public class GenericCrawlerActor : ReceiveActor
    {
        public GenericCrawlerActor()
        {
            Initialize();
        }

        private void Initialize()
        {
            Receive<Messages.BeginScraping>(scrapingdata =>
            {
                new GenericParser().BeginScrapeAsync().PipeTo(Self);
            });

            ReceiveAsync<Messages.BeginParsing>(async scrapingdata =>
            {
                var data = await new GenericParser().Parse();
                Context.Parent.Tell(new ScrapingFinished(data.Price, true));
          });
        }
    }
}
