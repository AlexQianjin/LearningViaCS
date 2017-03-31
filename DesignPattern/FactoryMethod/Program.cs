using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            IProduct product;

            for (int i = 1; i <= 12; i++)
            {
                product = c.FactoryMethod(i);
                Console.WriteLine($"Avocados {product.ShipFrom()}");
            }

            Console.ReadLine();
        }
    }
}