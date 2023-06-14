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

            var group = new Group();
            //group.addShape(group1); this is not possible with current implementation
            // Represent hirarchy structure not possible will do changes next

            group.addShape(group1);
            group.addShape(group2);
            group.render();


        }
    }
}
