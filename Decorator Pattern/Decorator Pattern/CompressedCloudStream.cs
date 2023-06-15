using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class CompressedCloudStream : CloudStream
    {
        public override void write(string data)
        {
            var compressed = compress(data);
            base.write(compressed);
        }

        private string compress(string data)
        {
            return "compressed : " + data;
        }
    }
}
