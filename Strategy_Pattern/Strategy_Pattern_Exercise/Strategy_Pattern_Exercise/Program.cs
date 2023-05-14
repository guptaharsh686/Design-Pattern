using System;

namespace Strategy_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var chatClient = new ChatClient();

            chatClient.send("hello", new AES_Encryption());
            chatClient.send("hello", new DES_Encryption());

        }
    }
}
