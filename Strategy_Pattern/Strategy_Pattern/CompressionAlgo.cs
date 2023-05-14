using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public interface CompressionAlgo
    {
        void compress(string fileName);
    }
}
