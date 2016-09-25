namespace Octo.Infrastructure.Messages
{
    public class ScrapingFinished
    {
        public ScrapingFinished(decimal price, bool success)
        {
            Success = success;
            Price = price;
        }

        public bool Success { get; private set; }
        public decimal Price { get; private set; }
    }
}
