using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Observer : IObserver
    {
        private string name;
        private Subject subject;
        private string state;
        private string gap;

        public Observer(Subject subject, string name, string gap)
        {
            this.subject = subject;
            this.name = name;
            this.gap = gap;
            subject.Notify += Update;
        }

        public void Update(string subjectState)
        {
            state = subjectState;
            Console.WriteLine(gap + name + ": " + state);
        }
    }
}
