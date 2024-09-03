using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class HighContrastFilter : Filter
    {
        public void apply(string fileName)
        {
            Console.WriteLine("Apply high contrast filter");
        }
    }
}
