using System;

namespace Singleton_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var logger1 = Logger.getInstance();
            logger1.setFileName("file");
            logger1.write("msg");


            var logger2 = Logger.getInstance();
            logger2.setFileName("file2");
            logger2.write("msg2");
        }
    }
}
