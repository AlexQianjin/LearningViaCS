using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ProductA : IProduct
    {
        public string ShipFrom()
        {
            return "  from South Africa";
        }
    }
}
