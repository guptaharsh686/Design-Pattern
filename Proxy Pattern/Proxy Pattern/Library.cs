using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    public class Library
    {

        private Dictionary<string, IEbook> ebooks = new Dictionary<string, IEbook>();

        public void add(EBookProxy ebook)
        {
            ebooks.Add(ebook.getfileName(), ebook);
        }

        public void openEbook(string fileName)
        {
            Console.WriteLine("Opening Real EBook");
            IEbook value;
            ebooks.TryGetValue(fileName,out value);
            value.show();


        }
    }
}
