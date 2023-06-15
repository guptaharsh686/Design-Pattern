using System;
using System.Collections.Generic;
using System.Text;
using Ava_Filters;

namespace Adapter_Pattern
{
    public class CaramelFilterAdapter : IFilter
    {
        private CaramelFilter caramelFilter;

        public CaramelFilterAdapter(CaramelFilter caramelFilter)
        {
            this.caramelFilter = caramelFilter;
        }

        public void apply(Image image)
        {
            caramelFilter.init();
            caramelFilter.render(image);
        }
    }
}
