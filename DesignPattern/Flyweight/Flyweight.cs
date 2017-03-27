using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public struct Flyweight : IFlyweight
    {
        private Image pThumbnail;

        public void Load(string filename)
        {
            throw new NotImplementedException();
        }

        public void Display(PaintEventArgs e, int row, int col)
        {
            throw new NotImplementedException();
        }
    }
}
