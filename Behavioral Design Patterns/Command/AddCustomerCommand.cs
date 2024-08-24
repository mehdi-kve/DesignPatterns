using CommandAction.Framework;

namespace CommandAction
{
    public class AddCustomerCommand : Command
    {
        private CustomerService service;

        public AddCustomerCommand(CustomerService customerService)
        {
            this.service = customerService; 
        }

        public void Execute()
        {
            service.addCustomer();
        }
    }
}
