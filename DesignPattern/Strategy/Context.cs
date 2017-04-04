using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Context
    {
        public const int start = 5;
        public int Counter = 5;

        IStrategy strategy = new Strategy1();

        public int Algorithm()
        {
            return strategy.Move(this);
        }

        public void SwitchStrategy()
        {
            if (strategy is Strategy1)
            {
                strategy = new Strategy2();
            }
            else
            {
                strategy = new Strategy1();
            }
        }
    }
}
