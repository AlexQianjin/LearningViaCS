using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Builder2 : IBuilder
    {
        private Product product = new Product();

        public void BuildPartA()
        {
            product.Add("PartX ");
        }

        public void BuildPartB()
        {
            product.Add("PartY ");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
