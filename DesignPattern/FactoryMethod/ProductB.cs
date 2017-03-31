using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ProductB : IProduct
    {
        public string ShipFrom()
        {
            return " from Spain";
        }
    }
}
