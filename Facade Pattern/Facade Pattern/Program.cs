using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var server = new NotificationServer();
            var connection = server.connect("ip");
            var token = server.authenticate("appID", "key");
            var message = new Message("Hello");
            server.send(token, message, "targetip");

        }
    }
}
