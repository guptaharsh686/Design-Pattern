using System;

namespace Template_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var window1 = new Window1();
            var window2 = new Window2();

            window1.close();
            window2.close();
        }
    }
}
