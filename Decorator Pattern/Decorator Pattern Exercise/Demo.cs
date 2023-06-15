using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern_Exercise
{
    public class Demo
    {
        public static void show()
        {
            var editor = new Editor();
            editor.openProject("...");
        }
    }
}
