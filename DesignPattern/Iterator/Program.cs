using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthCollection collection = new MonthCollection();
            foreach (string n in collection)
            {
                Console.Write(n + "    ");
            }

            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}