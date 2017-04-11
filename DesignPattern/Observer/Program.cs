using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            Observer observer = new Observer(subject, "Center", "\t\t");
            Observer observer2 = new Observer(subject, "Right", "\t\t\t\t");
            subject.Go();

            Console.ReadLine();
        }
    }
}