using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator m = new Mediator();
            Colleague head1 = new Colleague(m, "John");
            ColleagueB branch1 = new ColleagueB(m, "David");
            Colleague head2 = new Colleague(m, "Lucy");

            head1.Send("Meeting on Tuesday, please all ack");
            branch1.Send("Ack");
            m.Block(branch1.Receive);
            head1.Send("Still awaiting some Acks");
            head2.Send("Ack");
            m.Unblock(branch1.Receive);
            head1.Send("Thanks all");

            Console.ReadLine();
        }
    }
}