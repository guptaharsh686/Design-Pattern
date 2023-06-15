using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern_Exercise
{
    public class EmailClient
    {
        private List<EmailProvider> emailProviders = new List<EmailProvider>();

        public void addProvider(EmailProvider emailProvider)
        {
            emailProviders.Add(emailProvider);
        }

        public void downloadEmails()
        {
            foreach (var emailprovider in emailProviders)
            {
                emailprovider.downloadEmails();
            }
        }
    }
}
