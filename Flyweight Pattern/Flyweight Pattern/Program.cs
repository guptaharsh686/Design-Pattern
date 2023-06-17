using System;

namespace Flyweight_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var service = new PointService(new PointIConFactory());
            foreach (var point in service.GetPoints())
            {
                point.draw();
            }

        }
    }
}
