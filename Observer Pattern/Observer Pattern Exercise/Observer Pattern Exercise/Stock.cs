using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern_Exercise
{
    public class Stock : StockUpdate
    {
        private string symbol;
        private float price;

        public Stock(string symbol, float price)
        {
            this.symbol = symbol;
            this.price = price;
        }


        public float getPrice()
        {
            return price;
        }

        public void setPrice(float price)
        {
            this.price = price;
            notifyObservers();
        }

        public override string ToString()
        {
            return $"[Stock --- Symbol = {this.symbol}  Price = {this.price} ]]";
        }
    }
}
