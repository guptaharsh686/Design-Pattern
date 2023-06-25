using System;

namespace Proxy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var lib = new Library();
            string[] fileNames = new string[] { "a", "b", "c" };

            foreach (var fname in fileNames)
            {
                lib.add(new EBookProxy(fname));
            }

            lib.openEbook("a"); 
        }
    }
}
