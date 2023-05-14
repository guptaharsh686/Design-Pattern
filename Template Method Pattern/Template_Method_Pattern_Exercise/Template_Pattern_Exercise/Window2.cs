using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Pattern_Exercise
{
    public class Window2 : Window
    {
        protected override void toExecuteAfterClosing()
        {
            Console.WriteLine("Window 2 toExecuteAfterClosing");
        }

        protected override void toExecuteBeforeClosing()
        {
            Console.WriteLine("Window 2 toExecuteBeforeClosing");
        }
    }
}
