using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.SwitchStrategy();
            Random r = new Random(37);
            for (int i = Context.start; i < Context.start + 15; i++)
            {
                if (r.Next(3) == 2)
                {
                    Console.Write("||  ");
                    context.SwitchStrategy();
                }
                Console.Write(context.Algorithm() + "    ");
            }
            Console.ReadLine();
        }
    }
}