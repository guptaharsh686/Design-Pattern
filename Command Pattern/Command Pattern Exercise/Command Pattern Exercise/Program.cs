using System;

namespace Command_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var videoEditor = new VideoEditor();
            var history = new History();
            Console.WriteLine($"{videoEditor}\n\n");


            var contrastCommand = new ContrastCommand(history, videoEditor);
            contrastCommand.execute();

            Console.WriteLine($"{videoEditor}\n\n");

            var undo = new UndoCommand(history);
            undo.execute();
            Console.WriteLine($"{videoEditor}\n\n");

            var textComand = new TextCommand(videoEditor, history);
            textComand.execute();
            Console.WriteLine($"{videoEditor}\n\n");


            var undo2 = new UndoCommand(history);
            undo.execute();
            Console.WriteLine($"{videoEditor}\n\n");



        }
    }
}
