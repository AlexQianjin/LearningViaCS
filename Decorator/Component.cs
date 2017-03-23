using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Component : IComponent
    {
        public string Operation()
        {
            return "I am walking";
        }
    }
}
