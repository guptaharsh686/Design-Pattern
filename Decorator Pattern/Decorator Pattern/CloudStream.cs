using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class CloudStream : IStream
    {
        public void write(string data)
        {
            Console.WriteLine("Storing " + data);
        }
    }
}
