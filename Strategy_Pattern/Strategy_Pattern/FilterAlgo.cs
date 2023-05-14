using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public interface FilterAlgo
    {
        void apply(string filename);
    }
}
