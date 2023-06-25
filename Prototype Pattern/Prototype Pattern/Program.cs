using System;

namespace Prototype_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var context = new ContextMenu();
            context.Duplicate(new Circle());
        }
    }
}
