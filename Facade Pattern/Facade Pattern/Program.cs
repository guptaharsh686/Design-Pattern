using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var service = new NotificationService();
            service.send("Hello", "targetip");

        }
    }
}
