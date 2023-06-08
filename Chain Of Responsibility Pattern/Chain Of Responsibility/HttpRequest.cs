using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility
{
    public class HttpRequest
    {
        private string username;
        private string password;

        public HttpRequest(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string getusername()
        {
            return username;
        }

        public string getpassword()
        {
            return password;
        }
    }
}
