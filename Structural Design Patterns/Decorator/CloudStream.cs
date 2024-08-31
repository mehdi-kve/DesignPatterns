using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CloudStream : Stream
    {
        public virtual void write(string data) 
        {
            Console.WriteLine($"Storing {data}");
        }
    }
}
