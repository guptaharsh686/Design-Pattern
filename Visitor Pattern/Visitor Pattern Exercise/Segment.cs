using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern_Exercise
{
    public interface Segment
    {
        void execute(IFilterOperation filterOperation);
    }
}
