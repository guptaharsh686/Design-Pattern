using System;

namespace State_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();

            canvas.CurrentTool = new SelectionTool();
            canvas.MouseUpRequest();
            canvas.MouseDownRequest();

            canvas.CurrentTool = new BrushTool();
            canvas.MouseDownRequest();
            canvas.MouseUpRequest();
        }
    }
}
