using System;

namespace Adapter
{
    public class Adaptee
    {
        public double SpecificRequest(double a, double b)
        {
            return a / b;
        }
    }

    public interface ITarget
    {
        string Request(int i);
    }

    public class Adapter : Adaptee, ITarget
    {
        public string Request(int i)
        {
            return "Rough estimate is " + (int)Math.Round(SpecificRequest(i, 3));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adaptee first = new Adaptee();
            Console.WriteLine("Before the new standard\nPrecise reading: ");
            Console.WriteLine(first.SpecificRequest(5, 3));

            ITarget second = new Adapter();
            Console.WriteLine("\nMoving to the new standard");
            Console.WriteLine(second.Request(5));

            Console.ReadLine();
        }
    }
}