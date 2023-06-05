using System;

namespace Meadiator_Using_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var article = new ArticleDialogBox();
            article.simulateInteraction();
        }
    }
}
