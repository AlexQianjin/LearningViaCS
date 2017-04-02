using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Gucci : IBrand
    {
        public int Price => 1000;

        public string Material => "Crocodile Skin";
    }
}
