using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern_Exercise
{
    public class Timeline
    {
        private List<IComponent> components = new List<IComponent>();

        public void add(IComponent component)
        {
            components.Add(component);
        }
    }
}
