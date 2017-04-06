using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class Algorithm
    {
        public void TemplateMethod(IPrimitives a)
        {
            string s = a.Operation1() + a.Operation2();
            Console.WriteLine(s);
        }
    }
}
