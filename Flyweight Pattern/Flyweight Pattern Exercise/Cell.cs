using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern_Exercise
{
    public class Cell
    {
        private int row;
        private int column;
        private String content;
        private Attributes attributes;

        public Cell(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public void setContent(String content)
        {
            this.content = content;
        }

        public String getFontFamily()
        {
            return this.attributes.getFontFamily() ;
        }

        public void setFontFamily(String fontFamily)
        {
            this.attributes.setFontFamily(fontFamily);
        }

        public void setAttributeContext(Attributes attributes)
        {
            this.attributes = attributes;
        }

        public Attributes GetAttributeContext()
        {
            return this.attributes;
        }

        public void render()
        {
            Console.WriteLine($"({row},{column}): {content} [{this.attributes.getFontFamily()}]");
        }


    }
}
