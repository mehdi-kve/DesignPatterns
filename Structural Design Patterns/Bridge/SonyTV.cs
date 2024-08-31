using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SonyTV : Device
    {
        public void setChannel(int number)
        {
            Console.WriteLine($"Sony: Set Channel to {number}");
        }

        public void turnOff()
        {
            Console.WriteLine("Sony: Turn off");
        }

        public void turnOn()
        {
            Console.WriteLine("Sony: Turn on");
        }
    }
}
