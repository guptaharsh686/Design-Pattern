using System;
using System.Collections.Generic;
using System.Text;

namespace ItteratorPattern
{
    public class BrowseHistory
    {
        private List<string> urls = new List<string>();


        public void push(string url)
        {
            urls.Add(url);
        }

        public string pop()
        {
            var lastUrl = urls[urls.Count - 1];
            urls.Remove(lastUrl);

            return lastUrl;
        }


        public Itterator createItterator()
        {
            return new ListItterator(this);
        }

        //declaring ListItterator class as a nested class of Browser history class
        //because we can access private members of the browsehistory class like urls property
        public class ListItterator : Itterator
        {
            private BrowseHistory history;
            private int index;

            public ListItterator(BrowseHistory history)
            {
                this.history = history;
            }

            public string current()
            {
                return history.urls[index]; 
            }

            public bool hasNext()
            {
                return (index < history.urls.Count);
            }

            public void Next()
            {
                index++; 
            }
        }


    }
}
