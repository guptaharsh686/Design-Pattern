using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Pattern
{
    public class Shape : IComponent
    {
        public void move()
        {
            Console.WriteLine("Moving Shape");
        }

        public void render()
        {
            Console.WriteLine("Render Shape");
        }
    }
}
