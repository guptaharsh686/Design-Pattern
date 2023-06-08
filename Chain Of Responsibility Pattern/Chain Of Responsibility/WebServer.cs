using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility
{
    public class WebServer
    {
        private Handler next;

        public WebServer(Handler handle)
        {
            this.next = handle;
        }


        public void handle_request(HttpRequest httpRequest)
        {
            next.handle(httpRequest);
            // Authentication
            // Compression
            // Logging
        }
    }
}
