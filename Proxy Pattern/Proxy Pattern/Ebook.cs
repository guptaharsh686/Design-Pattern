using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    public class Ebook
    {
        private string fileName;

        public Ebook(string fileName)
        {
            this.fileName = fileName;
            load();
        }


        private void load()
        {
            Console.WriteLine($"Loading EBook : {fileName}");
            //here we are initializing/loading from database
            //we must do this only when it is asked
        }

        public void show()
        {
            Console.WriteLine($"Showing the EBook : {fileName} ");
        }

        public string getfileName()
        {
            return fileName;
        }
    }
}
