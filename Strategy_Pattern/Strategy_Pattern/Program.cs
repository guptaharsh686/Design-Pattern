using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var imagestorage = new ImageStorage(new jpegCompression(), new  BandWFilter());

            imagestorage.store("a");
        
        }
    }
}
