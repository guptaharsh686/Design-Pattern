using System;

namespace Composite_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var square1 = new Shape();
            var square2 = new Shape();

            var rectangle1 = new Shape();
            var rectangle2 = new Shape();

            var group1 = new Group();
            group1.addShape(square1);
            group1.addShape(square2);

            var group2 = new Group();
            group2.addShape(rectangle1);
            group2.addShape(rectangle2);

            group1.render();
            group2.render();

        }
    }
}
