﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class NotificationServer
    {
        public Connection connect(string ipAddress)
        {
            return new Connection(); 
        }

        public AuthToken authenticate(string appID, string key) 
        {
            return new AuthToken();
        }

        public void send(AuthToken authToken, Message message, string target)
        {
            Console.WriteLine("Sending a message");
        }

    }
}
