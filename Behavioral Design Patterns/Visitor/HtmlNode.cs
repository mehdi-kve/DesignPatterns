using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface HtmlNode
    {
        void execute(Visitor visitor);
    }
}
