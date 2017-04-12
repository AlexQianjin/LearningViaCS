using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ElementWithLink : Element
    {
        public ElementWithLink(Element link, Element next)
        {
            this.Next = next;
            this.Link = link;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
