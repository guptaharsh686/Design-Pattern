using System;
using System.Collections.Generic;
using System.Text;

namespace State_Pattern
{
    public class ErasorTool : Canvas
    {
        public ErasorTool(ToolType tool)
        {
            CurrentTool = tool;
        }

        public override void MouseDown()
        {
            Console.WriteLine("Erasor Icon");
        }

        public override void MouseUp()
        {
            Console.WriteLine("Erase Shape on canvas");
        }
    }
}
