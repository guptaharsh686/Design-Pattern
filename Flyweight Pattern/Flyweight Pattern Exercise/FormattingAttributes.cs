using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern_Exercise
{
    public class FormattingAttributes
    {
        private string fontFamily;
        private int fontSize;
        private bool isBold;

        public FormattingAttributes(string fontFamily, int fontSize, bool isBold)
        {
            this.fontFamily = fontFamily;
            this.fontSize = fontSize;
            this.isBold = isBold;
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
    }
}
