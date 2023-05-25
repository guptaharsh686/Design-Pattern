using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern_Exercise
{
    public class StockUpdate
    {

        private List<IStockPriceObservercs> stockPriceObservercs = new List<IStockPriceObservercs>();

        public void addObservers(IStockPriceObservercs obs)
        {
            stockPriceObservercs.Add(obs);
        }

        public void removeObserver(IStockPriceObservercs obs)
        {
            stockPriceObservercs.Remove(obs);
        }

        public void notifyObservers()
        {
            foreach (var obs in stockPriceObservercs)
            {
                obs.priceUpdate();
            }
        }
    }
}
