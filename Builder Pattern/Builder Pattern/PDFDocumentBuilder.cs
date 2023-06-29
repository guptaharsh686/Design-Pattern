using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class PDFDocumentBuilder : PresentationBuilder
    {
        private PDFDocument document = new PDFDocument();
        public void addSlide(Slide slide)
        {
            document.addPage(slide.getText());
        }


        public PDFDocument getPDFDocument()
        {
            return document;
        }
    }
}
