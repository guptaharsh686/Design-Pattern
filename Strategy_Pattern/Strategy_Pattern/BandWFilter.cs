using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class BandWFilter : FilterAlgo
    {
        public void apply(string filename)
        {
            Console.WriteLine("Applying B and W filter"); 
        }
    }
}
