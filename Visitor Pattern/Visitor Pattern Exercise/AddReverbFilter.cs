using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern_Exercise
{
    public class AddReverbFilter : IFilterOperation
    {
        public void apply(FactSegment factSegment)
        {
            Console.WriteLine("Adding AddReverb filter to FactSegment");
        }

        public void apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Adding AddReverb filter to FormatSegment");
        }
    }
}
