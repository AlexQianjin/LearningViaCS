using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Component<T> : IComponent<T>
    {
        public T Name { get; set; }

        public Component(T name)
        {
            Name = name;
        }

        public void Add(IComponent<T> c)
        {
            Console.WriteLine("Cannot add to an item");
        }

        public IComponent<T> Remove(T s)
        {
            Console.WriteLine("Cannot remove directly");
            return this;
        }

        public string Display(int depth)
        {
            return new String('-', depth) + Name + "\n";
        }

        public IComponent<T> Find(T s)
        {
            if (s.Equals(Name))
            {
                return this;
            }
            else
            {
                return null;
            }
        }
    }
}
