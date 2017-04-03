using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Builder1 : IBuilder
    {
        private Product product = new Product();

        public void BuildPartA()
        {
            product.Add("PartA ");
        }

        public void BuildPartB()
        {
            product.Add("PartB ");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
