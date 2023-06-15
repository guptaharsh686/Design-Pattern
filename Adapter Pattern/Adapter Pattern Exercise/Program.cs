using Adapter_Pattern_Exercise.Gmail;
using System;

namespace Adapter_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var emailClient = new EmailClient();
            emailClient.addProvider(new GmailProviderAdapter(new GmailClient()));
            emailClient.downloadEmails();

        }
    }
}
