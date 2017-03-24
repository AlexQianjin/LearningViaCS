using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DecoratorA : IComponent
    {
        private IComponent component;

        public DecoratorA(IComponent c)
        {
            component = c; 
        }

        public string Operation()
        {
            string s = component.Operation();
            s += " and listening to Classic FM ";

            return s;
        }
    }
}
