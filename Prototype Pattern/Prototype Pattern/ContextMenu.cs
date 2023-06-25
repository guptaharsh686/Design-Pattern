using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern
{
    public class ContextMenu
    {
        public void Duplicate(IComponent component)
        {
            if(component is Circle)
            {
                var source = (Circle)component;
                var dist = new Circle();
                dist.Radius = source.Radius;
                Console.WriteLine("Circle duplicated");
            }
        }
    }
}
