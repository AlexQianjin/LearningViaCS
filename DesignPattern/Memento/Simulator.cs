using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Simulator : IEnumerable
    {
        private string[] lines = {
             "The curfew tolls the knel of parting day",
             "The lowing herd winds slowly o'er the lea",
             "Uh hum uh hum",
             "*Undo",
             "The plowman homeward plods his weary way",
             "And leaves the world to darkness and to me."};

        public IEnumerator GetEnumerator()
        {
            foreach (string element in lines)
            {
                yield return element;
            }
        }
    }
}
