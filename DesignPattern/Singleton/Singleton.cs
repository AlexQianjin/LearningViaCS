using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Singleton
    {
        private Singleton()
        {

        }

        private static readonly Singleton instance = new Singleton();

        public static Singleton UniqueInstance
        {
            get { return instance; }
        }

        public void Log(string log)
        {
            Console.WriteLine(log);
        }
    }
}
