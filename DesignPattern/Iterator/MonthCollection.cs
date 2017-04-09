using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class MonthCollection : IEnumerable
    {
        private string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public IEnumerator GetEnumerator()
        {
            foreach (string element in months)
            {
                yield return element;
            }
        }
    }
}
