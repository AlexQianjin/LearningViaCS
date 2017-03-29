using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryForFacade
{
    public static class Facade
    {
        static SubsystemA a = new SubsystemA();
        static SubsystemB b = new SubsystemB();
        static SubsystemC c = new SubsystemC();

        public static void Operation1()
        {
            Console.WriteLine("Operation 1\n" + a.A1() + a.A2() + b.B1());
        }

        public static void Operation2()
        {
            Console.WriteLine("Operation 2\n" + b.B1() + c.C1());
        }
    }
}
