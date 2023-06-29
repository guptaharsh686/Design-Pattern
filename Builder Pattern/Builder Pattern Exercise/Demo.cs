using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern_Exercise
{
    public class Demo
    {
        public static void show() 
        {
            var document = new Document();
            document.add(new Text("Hello World"));
            document.add(new Image("pic1.jpg"));

            document.export(new HTMLBuilder(), "export.html");

            // Only writes the text elements to the file
            document.export(new TextBuilder(), "export.txt");
        }
}
}
