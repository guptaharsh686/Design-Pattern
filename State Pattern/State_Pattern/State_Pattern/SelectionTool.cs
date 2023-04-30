using System;
using System.Collections.Generic;
using System.Text;

namespace State_Pattern
{
    public class SelectionTool : Canvas
    {
        public SelectionTool(ToolType tool)
        {
            CurrentTool = tool;
        }

        public override void MouseDown()
        {
            Console.WriteLine("Selection Icon");
        }

        public override void MouseUp()
        {
            Console.WriteLine("Draw Dashed Rectangle");
        }
    }
}
