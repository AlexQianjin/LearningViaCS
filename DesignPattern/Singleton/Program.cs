using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.UniqueInstance;
            singleton.Log("Initialize");

            SingletonLazy singletonLazy = SingletonLazy.UniqueInstance;
            singletonLazy.Log("Lazy Initialize");

            Console.ReadLine();
        }
    }
}