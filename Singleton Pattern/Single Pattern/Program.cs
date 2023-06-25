using System;

namespace Single_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var config = new ConfigurationManager();
            config.set("wadawd", "adWADadQW");

            Console.WriteLine(config.get("wadawd"));

            // the problem
            var config1 = new ConfigurationManager();
            // will give null because this is different instance
            Console.WriteLine(config1.get("wadawd") == null ? "null" : config1.get("wadawd"));



        }
    }
}
