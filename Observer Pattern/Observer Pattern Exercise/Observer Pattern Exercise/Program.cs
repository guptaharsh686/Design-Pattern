using System;

namespace Observer_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var stock1 = new Stock("Hello", 20);
            var stock2 = new Stock("Harsh", 30);
            var stock3 = new Stock("Ankit", 40);
            var stock4 = new Stock("Varad", 50);


            var sb = new StatusBar();
            var slv = new StockListView();

            sb.addStock(stock1);
            sb.addStock(stock2);
            sb.addStock(stock3);


            slv.addStock(stock1);
            slv.addStock(stock2);
            slv.addStock(stock4);

            stock1.addObservers(sb);
            stock2.addObservers(sb);
            stock3.addObservers(sb);

            stock1.addObservers(slv);
            stock2.addObservers(slv);
            stock4.addObservers(slv);

            Console.WriteLine("Status Bar ------");
            sb.show();
            Console.WriteLine("StatusList View ------");
            slv.show();

            Console.WriteLine("Changing the values");

            stock1.setPrice(11);
            stock2.setPrice(22);
            stock3.setPrice(33);
            stock4.setPrice(44);
        }
    }
}
