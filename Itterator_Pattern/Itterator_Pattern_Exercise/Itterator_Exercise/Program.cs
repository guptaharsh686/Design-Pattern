using System;

namespace Itterator_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var products = new ProductCollection();

            products.add(new Product(1, "a"));
            products.add(new Product(2, "b"));
            products.add(new Product(3, "c"));

            IIterator pr = products.createIterator();

            while (pr.hasNext())
            {
                Console.WriteLine($"{pr.current()}");
                pr.Next();
            }
        }
    }
}
