using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ds = new DataSource();

            var sheet1 = new SpreadSheet();
            var sheet2 = new SpreadSheet();
            var chart = new Chart();

            ds.addObserver(sheet1);
            ds.addObserver(sheet2);
            ds.addObserver(chart);

            ds.setValue(1);

        }
    }
}
