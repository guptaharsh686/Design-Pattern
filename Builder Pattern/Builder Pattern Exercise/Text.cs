using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern_Exercise
{
    public class Text : Element
    {
        private string content;

        public Text(string content)
        {
            this.content = content;
        }

        public string getContent()
        {
            return content;
        }
    }
}
