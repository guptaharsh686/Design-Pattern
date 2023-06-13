using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public interface IOperation
    {
        void apply(HeadingNode operation);
        void apply(AnchorNode operation);
    }
}
