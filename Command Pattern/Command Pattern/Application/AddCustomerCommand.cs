using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern.Application
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService service;

        public AddCustomerCommand(CustomerService customerService)
        {
            this.service = customerService;
        }

        public void execute()
        {
            service.addCustomer();
        }
    }
}
