using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class FlyweightFactory
    {
        Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();

        public FlyweightFactory()
        {
            flyweights.Clear();
        }

        public IFlyweight this[string index]
        {
            get
            {
                if (!flyweights.ContainsKey(index))
                {
                    flyweights[index] = new Flyweight();
                }

                return flyweights[index];
            }
        }
    }
}
