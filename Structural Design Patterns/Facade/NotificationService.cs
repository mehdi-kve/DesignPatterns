using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class NotificationService
    {
        public void send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.connect(ipAddress: "ip");
            var authToken = server.authenticate(appID: "appID", key: "KEY");
            server.send(authToken, new Message(message), target);
            connection.disconnect();
        }
    }
}
