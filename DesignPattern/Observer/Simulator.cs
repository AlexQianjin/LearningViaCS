using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Simulator : IEnumerable
    {
        private string[] moves = { "5", "3", "1", "6", "7" };

        public IEnumerator GetEnumerator()
        {
            foreach (string element in moves)
            {
                yield return element;
            }
        }
    }
}
