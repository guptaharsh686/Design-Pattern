using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_Exercise
{
    public class AES_Encryption : EncryprionAlgorithm
    {
        public void encrypt()
        {
            Console.WriteLine("Encrypted using AES");
        }
    }
}
