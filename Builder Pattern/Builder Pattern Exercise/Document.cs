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

        public void export(DocumentBuilder builder, String fileName)
        {
            String content = "";

            foreach (var ele in elements)
            {
                builder.add(ele);
            }

            content = builder.getContent();

            File.WriteAllText(fileName, content);
    }
    }
}
