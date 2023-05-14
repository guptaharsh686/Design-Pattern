using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class pngCompression : CompressionAlgo
    {
        public void compress(string fileName)
        {
            Console.WriteLine("compression by png");
        }
    }
}
