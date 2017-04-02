using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IBrand
    {
        int Price { get; }
        string Material { get; }
    }
}
