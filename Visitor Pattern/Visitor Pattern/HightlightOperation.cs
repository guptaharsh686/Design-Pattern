using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public class HightlightOperation : IOperation
    {
        public void apply(HeadingNode operation)
        {
            Console.WriteLine("Hightlight HeadingNode");
        }

        public void apply(AnchorNode operation)
        {
            Console.WriteLine("Hightlight AnchorNode");
        }
    }
}
