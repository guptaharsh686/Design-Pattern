using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StoreCreditCard(new CloudStream());

            //decorating with compression
            StoreCreditCard(new CompressedCloudStream(new CloudStream()));

            //decorating with encryption + compression
            StoreCreditCard(new EncryptedCloudStream(new CompressedCloudStream(new CloudStream())));

        }

        public static void StoreCreditCard(IStream stream)
        {
            stream.write("1234-5678-7890-2345");
        }
    }
}
