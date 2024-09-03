using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class PlaintextVisitor : Visitor
    {
        public void apply(HeadingNode haeding)
        {
            Console.WriteLine("text-heading");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("text-anchor");
        }
    }
}
