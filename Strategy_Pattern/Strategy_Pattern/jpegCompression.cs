using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class jpegCompression : CompressionAlgo
    {
        public void compress(string fileName)
        {
            Console.WriteLine( "Compression by jpeg");
        }
    }
}
