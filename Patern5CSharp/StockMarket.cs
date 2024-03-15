using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern5CSharp
{
    public class StockMarket : ISubject
    {
        private List<IObserver> observers;
        private Dictionary<string, decimal> stocks;

        public StockMarket()
        {
            observers = new List<IObserver>();
            stocks = new Dictionary<string, decimal>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update("Stock Market", 1);
            }
        }

        public void AddStock(string symbol, decimal price)
        {
            stocks[symbol] = price;
            NotifyObservers();
        }

        public void UpdateStockPrice(string symbol, decimal newPrice)
        {
            if (stocks.ContainsKey(symbol))
            {
                stocks[symbol] = newPrice;
                NotifyObservers();
            }
        }
    }
}
