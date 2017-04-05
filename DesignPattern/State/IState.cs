using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface IState
    {
        int MoveUp(Context context);
        int MoveDown(Context context);
    }
}
