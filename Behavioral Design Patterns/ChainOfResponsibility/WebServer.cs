﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class WebServer
    {
        private Handler _handler;

        public WebServer(Handler handler)
        {
            this._handler = handler;
        }

        public void Handle(HttpRequest request) 
        {
            _handler.Handle(request); 
        }
    }
}
