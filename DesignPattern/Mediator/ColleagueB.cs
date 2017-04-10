using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ColleagueB : Colleague
    {
        public ColleagueB(Mediator mediator, string name) : base(mediator, name)
        {

        }

        public override void Receive(string message, string from)
        {
            if (!string.Equals(from, name))
            {
                Console.WriteLine($"{name} received from {from}: {message}");
            }
        }
    }
}
