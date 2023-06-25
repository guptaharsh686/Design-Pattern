using System;

namespace Singleton_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var logger1 = Logger.getInstance("file");
            logger1.write("msg");


            var logger2 = Logger.getInstance("file2");
            logger2.write("msg2");


            var logger_duplicate = Logger.getInstance("file2");
            logger_duplicate.write("msg3");
        }
    }
}
