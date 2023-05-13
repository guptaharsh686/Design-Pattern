using System;

namespace ItteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var history = new BrowseHistory();
            history.push("a");
            history.push("b");
            history.push("c");

            //programming to a itterator interface
            Itterator iterator = history.createItterator();

            while (iterator.hasNext())
            {
                var url = iterator.current();
                Console.WriteLine($"{url}");
                iterator.Next();
            }
        }
    }
}
