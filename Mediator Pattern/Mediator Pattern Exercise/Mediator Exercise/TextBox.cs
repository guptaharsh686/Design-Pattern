using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Exercise
{
    public class TextBox : UIControl
    {
        private string content;

        public string getContent()
        {
            return content;
        }

        public void setContent(string content)
        {
            this.content = content;
            notify();
        }
    }
}
