using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern_Exercise
{
    public class NormalizationFilter : IFilterOperation
    {
        public void apply(FactSegment factSegment)
        {
            Console.WriteLine("Adding Normalization filter to FactSegment");
        }

        public void apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Adding Normalization filter to FormatSegment");
        }
    }
}
