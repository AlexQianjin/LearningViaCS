using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Strategy1 : IStrategy
    {
        public int Move(Context c)
        {
            return ++c.Counter;
        }
    }
}
