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



        public void export(PresentationBuilder builder)
        {
            builder.addSlide(new Slide("Copyright"));
            foreach (var slide in slides)
            {
                builder.addSlide(slide); 
            }
        }
    }
}
