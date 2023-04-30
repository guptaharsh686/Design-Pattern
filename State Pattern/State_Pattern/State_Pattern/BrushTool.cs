using System;
using System.Collections.Generic;
using System.Text;

namespace State_Pattern
{
    public class BrushTool : Tool
    {
        public override void MouseDownHandle()
        {
           Console.WriteLine("BrushTool Mouse Down");
        }

        public override void MouseUpHandle()
        {
            Console.WriteLine("BrushTool Mouse Up");
        }
    }
}
