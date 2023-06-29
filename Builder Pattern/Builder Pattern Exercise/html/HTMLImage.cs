using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern_Exercise
{
    public class HTMLImage : HTMLElement
    {
        private string source;

        public HTMLImage(String source)
        {
            this.source = source;
        }

        public override string ToString()
        {
            return String.Format("<img src=\"%s\" />", source);
        }
    }
}
