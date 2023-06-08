using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility
{
    public class Authentication : Handler
    {
        private Handler next;

        public Authentication(Handler handle) : base(handle)
        {
        }


        protected override bool dohandle(HttpRequest http)
        {
            var isauthenticated = false;

            if(http.getusername() == "admin" && http.getpassword() == "1234")
            {
                isauthenticated = true;
            }
            Console.WriteLine("Authentication");
            return !isauthenticated;
        }
    }
}
