using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern_Exercise
{
    public class HTMLBuilder : DocumentBuilder
    {
        private HTMLDocument document = new HTMLDocument();
        public void add(Element element)
        {
            if (element is Text)
            {
                var text = ((Text)element).getContent();
                document.add(new HTMLParagraph(text));
            }
            else if (element is Image)
            {
                var source = ((Image)element).getSource();
                document.add(new HTMLImage(source));
            }
        }

        public string getContent()
        {
            return document.ToString();
        }
    }
}
