using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Factory<Brand> : IFactory<Brand> where Brand : IBrand, new()
    {
        public IBag CreateBag()
        {
            return new Bag<Brand>();
        }

        public IShoes CreateShoes()
        {
            return new Shoes<Brand>();
        }
    }
}
