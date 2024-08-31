using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class LgTV : Device
    {
        public void setChannel(int number)
        {
            Console.WriteLine($"LG: Set Channel to {number}");
        }

        public void turnOff()
        {
            Console.WriteLine("LG: Turn off");
        }

        public void turnOn()
        {
            Console.WriteLine("LG: Turn on");
        }
    }
}
