using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class CountVisitor : IVisitor
    {
        public int Count { get; set; }

        public void CountElements(Element element)
        {
            element.Accept(this);
            if (element.Link != null)
            {
                CountElements(element.Link);
            }

            if (element.Next != null)
            {
                CountElements(element.Next);
            }
        }
        public void Visit(Element element)
        {
            Count++;
        }

        public void Visit(ElementWithLink element)
        {
            Console.WriteLine("Not counting");
        }
    }
}
