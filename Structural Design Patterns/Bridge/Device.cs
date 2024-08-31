using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface Device
    {
        void turnOn();
        void turnOff();
        void setChannel(int number);
    }
}
 