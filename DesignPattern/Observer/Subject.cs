using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Observer
{
    public class Subject
    {
        public delegate void Callback(string s);

        public event Callback Notify;

        private Simulator simulator = new Simulator();
        private const int speed = 200;
        public string SubjectState { get; set; }

        public void Go()
        {
            new Thread(new ThreadStart(Run)).Start();
        }

        private void Run()
        {
            foreach (string s in simulator)
            {
                Console.WriteLine($"Subject: {s}");
                SubjectState = s;
                Notify(s);
                Thread.Sleep(speed);
            }
        }
    }
}
