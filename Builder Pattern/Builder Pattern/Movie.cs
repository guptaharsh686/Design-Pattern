using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class Movie
    {
        public void addFrame(string text,int duration)
        {
            Console.WriteLine("Adding a frame to movie");
        }
    }
}
