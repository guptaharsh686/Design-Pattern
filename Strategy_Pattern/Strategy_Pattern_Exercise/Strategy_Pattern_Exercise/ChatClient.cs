using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_Exercise
{
    public class ChatClient
    {

        public void send(string message,EncryprionAlgorithm encryptionAlgorithm)
        {
            encryptionAlgorithm.encrypt();

            Console.WriteLine("Sending the encrypted message...");
        }
    }
}
