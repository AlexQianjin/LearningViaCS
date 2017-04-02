using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Bag<Brand> : IBag where Brand : IBrand, new ()
    {
        //public int Price => throw new NotImplementedException();

        //public string Material => throw new NotImplementedException();
        private Brand myBrand;

        public Bag()
        {
            myBrand = new Brand();
        }

        public string Material { get { return myBrand.Material; } }
    }
}
