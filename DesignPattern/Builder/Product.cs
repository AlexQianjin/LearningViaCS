using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Product
    {
        private List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Dispaly()
        {
            Console.WriteLine("\nProduct Parts --------");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine();
        }
    }
}
