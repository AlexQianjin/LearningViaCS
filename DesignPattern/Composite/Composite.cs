using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Composite<T> : IComponent<T>
    {
        private List<IComponent<T>> list;
        public T Name { get; set; }

        public Composite(T name)
        {
            this.Name = name;
            this.list = new List<IComponent<T>>();
        }

        public void Add(IComponent<T> c)
        {
            this.list.Add(c);
        }

        private IComponent<T> holder = null;

        public IComponent<T> Remove(T s)
        {
            holder = this;
            IComponent<T> p = holder.Find(s);
            if (holder != null)
            {
                (holder as Composite<T>).list.Remove(p);
                return holder;
            }
            else
            {
                return this;
            }
        }

        public IComponent<T> Find(T s)
        {
            holder = this;
            if (this.Name.Equals(s))
            {
                return this;
            }
            IComponent<T> found = null;
            foreach (IComponent<T> c in list)
            {
                found = c.Find(s);
                if (found != null)
                {
                    break;
                }
            }
            return found;
        }

        public string Display(int depth)
        {
            StringBuilder s = new StringBuilder(new String('-', depth));
            s.Append("Set " + this.Name + " length :" + list.Count + "\n");
            foreach (IComponent<T> component in list)
            {
                s.Append(component.Display(depth + 2));
            }

            return s.ToString();
        }
    }
}
