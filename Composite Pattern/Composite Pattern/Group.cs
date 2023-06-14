using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    public class Group
    {
        private List<Shape> shapes = new List<Shape>();
        
        
        public void addShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void render()
        {
            foreach (var shape in shapes)
            {
                shape.render();
            }
        }

    }
}
