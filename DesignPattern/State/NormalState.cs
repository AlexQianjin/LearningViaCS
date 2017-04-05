using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class NormalState : IState
    {
        public int MoveDown(Context context)
        {
            if (context.Counter < Context.limit)
            {
                context.State = new FastState();
                Console.Write("||");
            }
            context.Counter -= 2;
            return context.Counter;
        }

        public int MoveUp(Context context)
        {
            context.Counter += 2;
            return context.Counter;
        }
    }
}
