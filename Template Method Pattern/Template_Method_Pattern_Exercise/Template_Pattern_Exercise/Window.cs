using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Pattern_Exercise
{
    public abstract class Window
    {
        public void close()
        {
            //TODO: custom windows may need to execute some code before the window
            // is closed.

            toExecuteBeforeClosing();

            Console.WriteLine("Removing the window from the screen");

            toExecuteAfterClosing();
            //TODO: custom windows may need to execute some code after the window
            // is closed.
        }

        protected abstract void toExecuteBeforeClosing();

        protected abstract void toExecuteAfterClosing();
    }
}
