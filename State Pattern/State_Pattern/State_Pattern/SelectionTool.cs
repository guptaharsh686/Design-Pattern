using System;
using System.Collections.Generic;
using System.Text;

namespace State_Pattern
{
    public class SelectionTool : Tool
    {
        public override void MouseDownHandle()
        {
            Console.WriteLine("SelectionTool Mouse Down");
        }

        public override void MouseUpHandle()
        {
            Console.WriteLine("SelectionTool Mouse Up");
        }
    }
}
