using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern
{
    public class Circle : IComponent
    {
        private int radius;

        public int Radius { get => radius; set => radius = value; }

        public void render()
        {
            Console.WriteLine("Rendering a circle");
        }
    }
}
