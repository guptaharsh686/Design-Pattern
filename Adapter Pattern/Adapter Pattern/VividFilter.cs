using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    public class VividFilter : IFilter
    {
        public void apply(Image image)
        {
            Console.WriteLine("Applying Vivid filter");
        }
    }
}
