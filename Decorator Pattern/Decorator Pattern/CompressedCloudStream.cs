using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class CompressedCloudStream : IStream
    {
        private IStream stream;

        public CompressedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void write(string data)
        {
            var compressed = compress(data);
            stream.write(compressed);
        }

        private string compress(string data)
        {
            return "compressed : " + data;
        }
    }
}
