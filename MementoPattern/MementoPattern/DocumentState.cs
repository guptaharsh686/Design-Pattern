using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class DocumentState
    {
        private string content;
        private string fontName;
        private int fontSize;

        public string getcontent()
        {
            return content;
        }

        public string getFontName()
        {
            return fontName;
        }

        public int getFontSize()
        {
            return fontSize;
        }

        public DocumentState(string content,string fontName,int fontSize)
        {
            this.content = content;
            this.fontName = fontName;
            this.fontSize = fontSize;
        }
    }
}
