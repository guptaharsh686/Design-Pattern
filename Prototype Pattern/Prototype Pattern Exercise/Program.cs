using System;

namespace Prototype_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var timeline = new Timeline();
            timeline.add(new Audio());
            timeline.add(new Clip());
            timeline.add(new Text("dkwjebckjw"));

            var contextMenu = new ContextMenu(timeline);

            contextMenu.duplicate(new Clip());
        }
    }
}
