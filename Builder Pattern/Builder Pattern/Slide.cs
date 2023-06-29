using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class Slide
    {
        private string text;

        public Slide(string text)
        {
            this.text = text;
        }

        public string getText()
        {
            return text;
        }
    }
}
