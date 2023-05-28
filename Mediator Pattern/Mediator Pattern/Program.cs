using System;

namespace Mediator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dialogBox = new ArticleDialogBox();

            dialogBox.simulateUIChanges();
        }
    }
}
 