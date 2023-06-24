using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    public class Library
    {

        private Dictionary<string, Ebook> ebooks = new Dictionary<string, Ebook>();

        public void add(Ebook ebook)
        {
            ebooks.Add(ebook.getfileName(), ebook);
        }

        public void openEbook(string fileName)
        {
            Ebook value;
            ebooks.TryGetValue(fileName,out value);
            value.show();


        }
    }
}
