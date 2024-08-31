using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RemoteControl
    {
        protected Device device;

        public RemoteControl(Device device)
        {
            this.device = device;
        }

        public void turnOn() 
        {
            device.turnOn();
        }

        public void turnOff() 
        {
            device.turnOff();
        }
    }
}
