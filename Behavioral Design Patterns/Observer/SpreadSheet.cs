using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class SpreadSheet : Observer
    {
        public void update()
        {
            Console.WriteLine("SpreadSheet got updated.");
        }
    }
}
