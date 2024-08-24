using CommandAction;
using CommandAction.Framework;

var service = new CustomerService();
var command = new AddCustomerCommand(service);
var button = new Button(command);
button.click();