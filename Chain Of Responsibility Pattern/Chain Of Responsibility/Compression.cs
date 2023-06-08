using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility
{
    public class Compression : Handler
    {
        public Compression(Handler handler) : base(handler)
        {
        }

        protected override bool dohandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Compression");
            return false;
        }
    }
}
