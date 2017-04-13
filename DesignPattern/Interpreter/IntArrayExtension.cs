using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public static class IntArrayExtension
    {
        public static string Display(this int[] a)
        {
            string s = "[";
            foreach (int i in a)
            {
                s += i + ", ";
            }

            return s.Substring(0, s.Length - 2) + "]";
        }
    }
}
