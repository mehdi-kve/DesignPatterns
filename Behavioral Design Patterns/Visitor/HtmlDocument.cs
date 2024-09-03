using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class HtmlDocument : HtmlNode
    {
        private List<HtmlNode> nodes = new List<HtmlNode>();

        public void add(HtmlNode node)
        {
            nodes.Add(node);
        }

        public void execute(Visitor visitor) 
        {
            foreach (HtmlNode node in nodes) 
            {
                node.execute(visitor);
            }
        }
    }
}
