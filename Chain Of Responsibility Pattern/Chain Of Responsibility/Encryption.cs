using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility
{
    public class Encryption : Handler
    {
        public Encryption(Handler handler) : base(handler)
        {
        }

        protected override bool dohandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Encryption");
            return false;
        }
    }
}
