using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern_Exercise
{
    public class Clip : IComponent
    {
        public IComponent clone()
        {
            var clone = new Clip();
            return clone;
        }
    }
}
