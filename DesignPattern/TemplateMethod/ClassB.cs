using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ClassB : IPrimitives
    {
        public string Operation1()
        {
            return "ClassB:Op1 ";
        }

        public string Operation2()
        {
            return "ClassB:Op2 ";
        }
    }
}
