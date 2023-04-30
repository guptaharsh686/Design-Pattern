using System;
using System.Collections.Generic;
using System.Text;

namespace State_Pattern
{
    public class Canvas
    {
        private Tool currentTool;

        public Tool CurrentTool { get => currentTool; set => currentTool = value; }

        public void MouseUpRequest() 
        {
            currentTool.MouseUpHandle();
        }

        public void MouseDownRequest() 
        {
            currentTool.MouseDownHandle();
        }
    }
}
