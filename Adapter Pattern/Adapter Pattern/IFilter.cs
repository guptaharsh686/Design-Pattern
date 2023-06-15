using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    public interface IFilter
    {
        void apply(Image image);
    }
}
