using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern_Exercise
{
    public class Audio : IComponent
    {
        public IComponent clone()
        {
            var clone = new Audio();
            return clone;
        }
    }
}
