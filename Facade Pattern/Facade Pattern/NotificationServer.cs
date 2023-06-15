using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class NotificationServer
    {
        public Connection connect(string ipAddress)
        {
            return new Connection();
        }

        public AuthenticationToken authenticate(string appID,string Key)
        {
            return new AuthenticationToken();
        }

        public void send(AuthenticationToken token,Message message,string target)
        {
            Console.WriteLine("Message Sent");
        }
    }
}
