using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ClassA : IPrimitives
    {
        public string Operation1()
        {
            return "ClassA:Op1 ";
        }

        public string Operation2()
        {
            return "ClassB:Op2 ";
        }
    }
}
