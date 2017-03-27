using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public interface IFlyweight
    {
        void Load(string filename);
        void Display(PaintEventArgs e, int row, int col);
    }
}
