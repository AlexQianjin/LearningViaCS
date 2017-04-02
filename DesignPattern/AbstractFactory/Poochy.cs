using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Poochy : IBrand
    {
        public int Price => new Gucci().Price / 3;

        public string Material => "Plastic";
    }
}
