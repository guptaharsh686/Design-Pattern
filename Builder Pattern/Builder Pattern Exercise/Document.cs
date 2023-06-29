using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Builder_Pattern_Exercise
{
    public class Document
    {
        private List<Element> elements = new List<Element>();

        public void add(Element element)
        {
            elements.Add(element);
        }

        public void export(ExportFormat format, String fileName)
        {
            String content = "";

            if (format == ExportFormat.HTML) {
                var document = new HTMLDocument();

                foreach (Element element in elements) 
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

                content = document.ToString();
            }
            else if (format == ExportFormat.TEXT)
            {
                var builder = new StringBuilder();

                foreach (Element element in elements)
                {
                    if (element is Text) 
                    {
                        var text = ((Text)element).getContent();
                        builder.Append(text);
                    }
                }

                content = builder.ToString();
            }

            File.WriteAllText(fileName, content);
    }
    }
}
