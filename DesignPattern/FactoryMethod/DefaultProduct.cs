using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class DefaultProduct : IProduct
    {
        public string ShipFrom()
        {
            return " not availabe";
        }
    }
}
