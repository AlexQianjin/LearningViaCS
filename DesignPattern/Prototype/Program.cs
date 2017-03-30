using System;

namespace Prototype
{
    class Program : IPrototype<Prototype>
    {
        static void Report(string s, Prototype a, Prototype b)
        {
            Console.WriteLine("\n" + s);
            Console.WriteLine("Prototype " + a + "\nCone        " + b);
        }

        static void Main(string[] args)
        {
            PrototypeManager manager = new PrototypeManager();
            Prototype c2, c3;

            c2 = manager.prototypes["Australia"].Clone();
            Report("Shallow cloning Australia\n===============", manager.prototypes["Australia"], c2);

            c2.Capital = "Sydney";
            Report("Altered Clone's shallow state: prototype unaffected", manager.prototypes["Australia"], c2);

            c2.Language.Data = "Chinese";
            Report("Altering Clone deep state: prototype affected ******", manager.prototypes["Australia"], c2);

            c3 = manager.prototypes["Germany"].DeepCopy();
            Report("Deep cloning Germany\n===============", manager.prototypes["Germany"], c3);

            c3.Capital = "Munich";
            Report("Altering Clone shallow state: prototype unaffected", manager.prototypes["Germany"], c3);

            c3.Language.Data = "Turkish";
            Report("Altering Clone deep state: prototype unaffected", manager.prototypes["Germany"], c3);

            Console.ReadLine();
        }
    }
}