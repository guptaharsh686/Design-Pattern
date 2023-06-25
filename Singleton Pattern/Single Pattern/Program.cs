using System;

namespace Single_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var config = ConfigurationManager.getInstance();
            config.set("wadawd", "adWADadQW");

            Console.WriteLine(config.get("wadawd"));

            // the solution
            var config1 = ConfigurationManager.getInstance();
            Console.WriteLine(config1.get("wadawd") == null ? "null" : config1.get("wadawd"));



        }
    }
}
