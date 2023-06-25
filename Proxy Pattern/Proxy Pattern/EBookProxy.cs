using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    public class EBookProxy : IEbook
    {
        private string fileName;
        private RealEbook ebook;

        public EBookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public string getfileName()
        {
            return fileName;
        }

        public void show()
        {
            if(ebook == null)
            {
                ebook = new RealEbook(fileName);
            }
            ebook.show();
        }
    }
}
