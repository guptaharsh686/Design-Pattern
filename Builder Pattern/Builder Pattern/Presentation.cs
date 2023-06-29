using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class Presentation
    {
        private List<Slide> slides = new List<Slide>();

        public void addSlide(Slide slide)
        {
            slides.Add(slide);
        }



        public void export(PresentationFormat presentationFormat)
        {
            if(presentationFormat == PresentationFormat.PDF)
            {
                var pdfdoc = new PDFDocument();
                foreach (var slide in slides)
                {
                    pdfdoc.addPage(slide.getText());
                }
            }
            else if(presentationFormat == PresentationFormat.MOVIE)
            {
                var mov = new Movie();
                foreach (var slide in slides)
                {
                    mov.addFrame(slide.getText(), 3);
                }
            }
        }
    }
}
