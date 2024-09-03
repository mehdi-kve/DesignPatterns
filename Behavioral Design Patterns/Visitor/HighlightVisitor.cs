using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class HighlightVisitor : Visitor
    {
        public void apply(HeadingNode haeding)
        {
            Console.WriteLine("Highlight-heading");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("Highlight-anchor");
        }
    }
}
