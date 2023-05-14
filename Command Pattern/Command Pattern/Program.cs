using System;
using Command_Pattern.Application;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var service = new CustomerService();
            var addCustomerCommand = new AddCustomerCommand(service);
            var addButton = new Button(addCustomerCommand);

            var searchCustomerCommand = new SearchCustomerCommand(service);
            var searchButton = new Button(searchCustomerCommand);

            addButton.click();
            searchButton.click();
        }
    }
}
