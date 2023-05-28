using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public class TextBox : UIControl
    {
        private string content;


        public TextBox(DialogBox owner) : base(owner)
        {
        }
    
        public string getContent()
        {
            return content;
        }

        public void setContent(string content)
        {
            this.content = content;
            owner.changed(this);
        }
    }
}
