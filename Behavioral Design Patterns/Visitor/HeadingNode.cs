using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class HeadingNode : HtmlNode
    {
        public void execute(Visitor visitor)
        {
            visitor.apply(this);
        }
    }
}
