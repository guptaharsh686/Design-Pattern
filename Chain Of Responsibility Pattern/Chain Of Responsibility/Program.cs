using System;

namespace Chain_Of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Authentication -> Compression -> Logging

            var logging = new Logging(null);
            var compression = new Compression(logging);
            var authenticator = new Authentication(compression);

            var webServer = new WebServer(authenticator);
            webServer.handle_request(new HttpRequest("admin", "1234"));
            webServer.handle_request(new HttpRequest("amit", "1234"));
        }
    }
}
