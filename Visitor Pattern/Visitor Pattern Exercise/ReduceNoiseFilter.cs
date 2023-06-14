using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern_Exercise
{
    public class ReduceNoiseFilter : IFilterOperation
    {
        public void apply(FactSegment factSegment)
        {
            Console.WriteLine("Adding reduce noise filter to FactSegment");
        }

        public void apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Adding reduce noise filter to FormatSegment");
        }
    }
}
