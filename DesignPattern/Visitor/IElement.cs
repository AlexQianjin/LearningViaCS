using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class IElement
    {
        public abstract void Accept(IVisitor visitor);
    }
}
