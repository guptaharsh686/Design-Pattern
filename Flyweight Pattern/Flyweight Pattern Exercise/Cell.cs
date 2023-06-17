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
        private String fontFamily;
        private int fontSize;
        private bool isBold;

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
            return fontFamily;
        }

        public void setFontFamily(String fontFamily)
        {
            this.fontFamily = fontFamily;
        }

        public int getFontSize()
        {
            return fontSize;
        }

        public void setFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

        public bool isBold_()
        {
            return isBold;
        }

        public void setBold(bool bold)
        {
            isBold = bold;
        }

        public void render()
        {
            Console.WriteLine($"({row},{column}): {content} [{fontFamily}]");
        }
    }
}
