using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class MovieBuilder : PresentationBuilder
    {
        private Movie mov = new Movie();
        public void addSlide(Slide slide)
        {
            mov.addFrame(slide.getText(), 3);
        }


        public Movie getMovie()
        {
            return mov;
        }
    }
}
