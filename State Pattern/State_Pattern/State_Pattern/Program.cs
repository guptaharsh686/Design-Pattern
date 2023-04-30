using System;

namespace State_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas Tool = new SelectionTool(ToolType.SELECTION);
            Tool.MouseUp();
            Tool.MouseDown();

            Tool = new ErasorTool(ToolType.ERASOR);
            Tool.MouseUp();
            Tool.MouseDown();
        }
    }
}
