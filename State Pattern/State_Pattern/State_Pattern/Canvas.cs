using System;

namespace State_Pattern
{
    public class Canvas
    {
        private ToolType currentTool;

        public ToolType CurrentTool { get => currentTool; set => currentTool = value; }

        public virtual void MouseDown()
        {
            Console.WriteLine("Mouse Down Canvas");

        }

        public virtual void MouseUp()
        {
            Console.WriteLine("Mouse UP Canvas");

        }

    }
}


