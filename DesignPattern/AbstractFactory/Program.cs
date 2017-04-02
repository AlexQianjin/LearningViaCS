using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client<Poochy>().ClientMain();
            new Client<Gucci>().ClientMain();
            new Client<Groundcover>().ClientMain();

            Console.ReadLine();
        }
    }
}