using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public class HeadingNode : HTMLNode
    {
        public void execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}
