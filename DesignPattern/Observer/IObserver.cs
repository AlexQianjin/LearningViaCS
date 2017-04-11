using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface IObserver
    {
        void Update(string state);
    }
}
