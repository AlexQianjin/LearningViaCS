using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IVisitor
    {
        void Visit(Element element);
        void Visit(ElementWithLink element);
    }
}
