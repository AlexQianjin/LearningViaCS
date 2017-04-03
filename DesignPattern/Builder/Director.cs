using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartB();
        }
    }
}
