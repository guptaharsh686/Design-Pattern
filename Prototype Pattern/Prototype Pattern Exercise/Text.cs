using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern_Exercise
{
    public class Text : IComponent
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
