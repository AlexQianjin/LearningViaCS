using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Groundcover : IBrand
    {
        public int Price => 2000;

        public string Material => "South Africa leather";
    }
}
