namespace WorkerBee.Runner
{
    using Akka.Actor;
    using Octo.Infrastructure.Actors;
    using Octo.Infrastructure.Messages;
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var system = ActorSystem.Create("CrawlerSystem");
            var genericCrawler = system.ActorOf<GenericCrawlerActor>("GenericCrawler");
            genericCrawler.Tell(new BeginScraping("https://www.tripadvisor.com", "LAX", "NYC", new DateTime(2017, 12, 12)));
            Console.ReadLine();
        }
    }
}
