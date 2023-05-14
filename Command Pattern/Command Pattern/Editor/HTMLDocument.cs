using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern.Editor
{
    public class HTMLDocument
    {
        private string content;

        public string getContent()
        {
            return content;
        }

        public void setContent(string content)
        {
            this.content = content;
        }


        public void makeBold()
        {
            content = "<b>" + content + "</b>";
        }
    }
}
