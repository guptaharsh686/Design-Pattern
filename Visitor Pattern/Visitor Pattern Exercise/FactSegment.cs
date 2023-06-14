using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern_Exercise
{
    public class FactSegment : Segment
    {
        public void execute(IFilterOperation filterOperation)
        {
            filterOperation.apply(this);
        }
    }
}
