using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern_Exercise
{
    public interface IFilterOperation
    {
        void apply(FactSegment factSegment);

        void apply(FormatSegment formatSegment);
    }
}
