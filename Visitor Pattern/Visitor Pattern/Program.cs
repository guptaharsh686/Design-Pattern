using System;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var htmldoc = new HTMLDocument();
            htmldoc.addNode(new HeadingNode());
            htmldoc.addNode(new AnchorNode());

            htmldoc.execute(new HightlightOperation());
            htmldoc.execute(new PlainTextOperation());
        }
    }
}
