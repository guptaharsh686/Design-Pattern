using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern_Exercise
{
    public class HTMLParagraph : HTMLElement
    {
        private string text;

        public HTMLParagraph(String text)
        {
            this.text = text;
        }

        public override string ToString()
        {
            return String.Format("<p>%s</p>", text);
        }
    }
}
