using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern_Exercise
{
    public class TextBuilder : DocumentBuilder
    {
        private StringBuilder builder = new StringBuilder();
        public void add(Element element)
        {
            if (element is Text)
            {
                var text = ((Text)element).getContent();
                builder.Append(text);
            }
        }

        public string getContent()
        {
            return builder.ToString();
        }
    }
}
