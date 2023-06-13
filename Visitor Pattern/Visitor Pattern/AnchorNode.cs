using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public class AnchorNode : HTMLNode
    {
        public void Highlight()
        {
            Console.WriteLine("Highlighting AnchorNode");
        }
    }
}
