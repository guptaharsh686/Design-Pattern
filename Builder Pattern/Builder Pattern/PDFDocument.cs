using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class PDFDocument
    {
        public void addPage(string text)
        {
            Console.WriteLine("Adding a page to PDF");
        }
    }
}
