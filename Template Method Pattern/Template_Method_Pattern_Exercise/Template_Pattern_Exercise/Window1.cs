using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Pattern_Exercise
{
    public class Window1 : Window
    {
        protected override void toExecuteAfterClosing()
        {
            Console.WriteLine("Window 1 toExecuteAfterClosing ");
        }

        protected override void toExecuteBeforeClosing()
        {
            Console.WriteLine("Window 1 toExecuteBeforeClosing ");
        }
    }
}
