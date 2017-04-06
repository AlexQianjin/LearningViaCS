using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm m = new Algorithm();

            m.TemplateMethod(new ClassA());
            m.TemplateMethod(new ClassB());

            Console.ReadLine();
        }
    }
}