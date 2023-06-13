using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public class HTMLDocument
    {
        private List<HTMLNode> nodes = new List<HTMLNode>();

        public void addNode(HTMLNode node)
        {
            nodes.Add(node);
        }

        public void execute(IOperation operation)
        {
            foreach (var node in nodes)
            {
                node.execute(operation);
            }
        }
    }
}
