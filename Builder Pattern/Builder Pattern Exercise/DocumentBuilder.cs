using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern_Exercise
{
    public interface DocumentBuilder
    {
        void add(Element element);

        string getContent();
    }
}
