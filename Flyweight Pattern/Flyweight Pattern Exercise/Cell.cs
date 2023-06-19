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

        public Cell(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public String getContent()
        {
            return content;
        }

        public void setContent(String content)
        {
            this.content = content;
        }

        public String getFontFamily()
        {
            return attributes.getFontFamily();
        }

        public void setFontFamily(String fontFamily)
        {
            attributes.setFontFamily(fontFamily);
        }

        public int getFontSize()
        {
            return attributes.getFontSize();
        }

        public void setFontSize(int fontSize)
        {
            attributes.setFontSize(fontSize);
        }

        public bool isBold_()
        {
            return attributes.isBold_();
        }

        public void setBold(bool bold)
        {
            attributes.setBold(bold);
        }

        public void render()
        {
            Console.WriteLine($"({row},{column}): {content} [{attributes.getFontFamily()}]");
        }
    }
}
