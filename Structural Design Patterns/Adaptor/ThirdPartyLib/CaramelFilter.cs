using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor.ThirdPartyLib
{
    public class CaramelFilter
    {
        public void init() { }

        public void render(Image image) 
        {
            Console.WriteLine("Applying Caramel Filter");
        }
    }
}
