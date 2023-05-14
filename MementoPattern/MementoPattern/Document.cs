using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class Document
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

        public void setContent(string content)
        {
            this.content = content;
        }

        public void setFontName(string fontName)
        {
            this.fontName = fontName;
        }

        public void setFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

        public DocumentState createState()
        {
            var state = new DocumentState(this.content, this.fontName, this.fontSize);
            return state;
        }

        public void restore(DocumentState state)
        {
            this.content = state.getcontent();
            this.fontName = state.getFontName();
            this.fontSize = state.getFontSize();
        }


    }
}
