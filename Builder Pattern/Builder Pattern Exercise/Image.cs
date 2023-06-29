using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern_Exercise
{
    public class Image : Element
    {
        private string source;

        public Image(string source)
        {
            this.source = source;
        }

        public string getSource()
        {
            return source;
        }
    }
}
