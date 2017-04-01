using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class SingletonLazy
    {
        private SingletonLazy()
        {

        }

        private class SingletonCreator
        {
            internal static readonly SingletonLazy uniqueInstance = null;
            static SingletonCreator()
            {
                 uniqueInstance = new SingletonLazy();
            }
        }

        public static SingletonLazy UniqueInstance
        {
            get { return SingletonCreator.uniqueInstance; }
        }

        public void Log(string log)
        {
            Console.WriteLine(log);
        }
    }
}
