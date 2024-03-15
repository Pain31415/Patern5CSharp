namespace Patern5CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            StockMarket stockMarket = new StockMarket();

            IObserver investor1 = new Investor("Investor 1");
            IObserver investor2 = new Investor("Investor 2");

            stockMarket.RegisterObserver(investor1);
            stockMarket.RegisterObserver(investor2);

            stockMarket.AddStock("AAPL", 150.25m);
            stockMarket.UpdateStockPrice("AAPL", 155.50m);
        }
    }
}
