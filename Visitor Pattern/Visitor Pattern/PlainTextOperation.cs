using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public class PlainTextOperation : IOperation
    {
        public void apply(HeadingNode operation)
        {
            Console.WriteLine($"Plain text in HeadingNode");
        }

        public void apply(AnchorNode operation)
        {
            Console.WriteLine($"Plain text in AnchorNode");
        }
    }
}
