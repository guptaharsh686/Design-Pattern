using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern_Exercise
{
    public class HTMLDocument
    {
        private List<HTMLElement> elements = new List<HTMLElement>();

        public void add(HTMLElement element)
        {
            elements.Add(element);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("<html>");
            foreach(HTMLElement element in elements)
                builder.Append(element.ToString());
            builder.Append("</html>");
            return builder.ToString();
        }
    }
}
