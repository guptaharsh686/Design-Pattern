using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern_Exercise
{
    public class Segment
    {
        public void reduceNoise()
        {
            Console.WriteLine("Reduce noise");
        }

        public void addReverb()
        {
            Console.WriteLine("Add reverb");
        }

        public void normalize()
        {
            Console.WriteLine("Normalize");
        }
    }
}
