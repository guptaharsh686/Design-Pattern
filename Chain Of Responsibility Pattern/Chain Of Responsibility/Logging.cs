using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility
{
    public class Logging : Handler
    {
        public Logging(Handler handler) : base(handler)
        {
        }

        protected override bool dohandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Logging");
            return true;
        }
    }
}
