using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern_Exercise
{
    public class Attributes
    {
        private String fontFamily;
        private int fontSize;
        private bool isBold;

        public Attributes(string fontFamily, int fontSize, bool isBold)
        {
            this.fontFamily = fontFamily;
            this.fontSize = fontSize;
            this.isBold = isBold;
        }

        public string getFontFamily()
        {
            return this.fontFamily;
        }

        public int getFontSize()
        {
            return this.fontSize;
        }

        public bool get_isBold()
        {
            return this.isBold;
        }

        public void setFontFamily(string fontFamily)
        {
            this.fontFamily = fontFamily;
        }

        public void setFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

        public void setisBold(bool is_bold)
        {
            this.isBold = is_bold;
        }

        private int _hashCode;


        public int hashCode
        {
            get
            {
                if(_hashCode == 0)
                {
                    var hash = new HashCode();
                    hash.Add(fontFamily);
                    hash.Add(fontSize);
                    hash.Add(isBold);

                    _hashCode = hash.ToHashCode();

                }
                return _hashCode;
            }
        }



    }
}
