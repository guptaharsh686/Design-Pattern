using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern_Exercise
{
    public class StockListView : IStockPriceObservercs
    {
        private List<Stock> stocks = new List<Stock>();

        public void addStock(Stock stock)
        {
            stocks.Add(stock);
        }

        public void priceUpdate()
        {
            Console.WriteLine("StockListView : Stock Price List Updated!");
            show();
        }

        public void show()
        {
            foreach (var stock in stocks)
            {
                Console.WriteLine(stock);

            }
        }
    }
}
