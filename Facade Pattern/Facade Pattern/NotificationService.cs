using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class NotificationService
    {
        public void send(string message,string target)
        {
            var server = new NotificationServer();
            var connection = server.connect("ip");
            var token = server.authenticate("appID", "key");
            server.send(token, new Message(message), target);
        }
    }
}
