using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    public class Group : IComponent
    {
        private List<IComponent> components = new List<IComponent>();
        
        
        public void addShape(IComponent shape)
        {
            components.Add(shape);
        }

        public void move()
        {
            foreach (var component in components)
            {
                component.move();
            }
        }

        public void render()
        {
            foreach (var component in components)
            {
                component.render();
            }
        }

    }
}
