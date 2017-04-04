using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IStrategy
    {
        int Move(Context c);
    }
}
