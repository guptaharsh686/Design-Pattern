using System;

namespace Chain_Of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Authentication -> Compression -> Logging
            // Authentication -> Compression -> Encryption -> Logging

            var logging = new Logging(null);
            var encryption = new Encryption(logging);
            var compression = new Compression(encryption);
            var authenticator = new Authentication(compression);

            var webServer = new WebServer(authenticator);
            webServer.handle_request(new HttpRequest("admin", "1234"));
            Console.WriteLine("-----------------------------------------------------");
            webServer.handle_request(new HttpRequest("amit", "1234"));
        }
    }
}
