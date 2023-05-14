using System;
using Command_Pattern.Application;
using Command_Pattern.Editor;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var history = new History();
            var document = new HTMLDocument();

            document.setContent("Hello World");

            var boldCommand = new BoldCommand(document, history);
            boldCommand.execute();
            Console.WriteLine($"{document.getContent()}");

            var undoCommand = new UndoCommand(history);
            undoCommand.execute();
            Console.WriteLine($"{document.getContent()}");

        }
    }
}
