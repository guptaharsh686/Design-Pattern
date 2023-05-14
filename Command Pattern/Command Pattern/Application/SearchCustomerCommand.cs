using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern.Application
{
    public class SearchCustomerCommand : ICommand
    {
        private CustomerService service;

        public SearchCustomerCommand(CustomerService service)
        {
            this.service = service;
        }

        public void execute()
        {
            service.searchCustomer();
        }
    }
}
