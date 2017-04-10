using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Colleague
    {
        private Mediator mediator;
        protected string name;

        public Colleague(Mediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
            this.mediator.SignOn(Receive);
        }

        public virtual void Receive(string message, string from)
        {
            Console.WriteLine($"{name} received from {from}: {message}");
        }

        public void Send(string message)
        {
            Console.WriteLine($"Send (From {name} ): {message}");
            mediator.Send(message, name);
        }
    }
}
