using System;

namespace Bridge
{
    class Program
    {
        public interface IBridge
        {
            string OperationImp();
        }

        public class Abstraction
        {
            IBridge bridge;

            public Abstraction(IBridge implementation)
            {
                bridge = implementation;
            }

            public string Operation()
            {
                return "Abstraction" + " <<< BRIDGE >>> " + bridge.OperationImp();
            }
        }

        public class ImplementationA : IBridge
        {
            public string OperationImp()
            {
                return "ImplementationA";
            }
        }

        public class ImplementationB : IBridge
        {
            public string OperationImp()
            {
                return "ImplementationB";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern\n");
            Console.WriteLine(new Abstraction(new ImplementationA()).Operation());
            Console.WriteLine(new Abstraction(new ImplementationB()).Operation());

            Console.ReadLine();
        }
    }
}