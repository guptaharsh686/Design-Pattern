 using System;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var presentation = new Presentation();
            presentation.addSlide(new Slide("Slide 1"));
            presentation.addSlide(new Slide("Slide 2"));
            presentation.addSlide(new Slide("Slide 3"));

            var builder = new PDFDocumentBuilder();
            presentation.export(builder);
            builder.getPDFDocument();


            var moviebuilder = new MovieBuilder();
            presentation.export(moviebuilder);
            moviebuilder.getMovie();


        }
    }
}
