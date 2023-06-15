using Adapter_Pattern_Exercise.Gmail;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern_Exercise
{
    class GmailProviderAdapter : EmailProvider
    {
        private GmailClient gmailClient;

        public GmailProviderAdapter(GmailClient gmailClient)
        {
            this.gmailClient = gmailClient;
        }

        public void downloadEmails()
        {
            gmailClient.connect();
            gmailClient.getEmails();
            gmailClient.disconnect();
        }
    }
}
