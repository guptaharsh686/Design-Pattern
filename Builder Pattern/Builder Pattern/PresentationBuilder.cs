using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public interface PresentationBuilder
    {
        void addSlide(Slide slide);
    }
}
