using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    [Serializable()]
    public class Originator
    {
        private List<string> state = new List<string>();

        public void Operation(string s)
        {
            state.Add(s);
            foreach (string line in state)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("========================");
        }

        public Memento SetMemento()
        {
            Memento memento = new Memento();
            return memento.Save(state);
        }

        public void GetMemento(Memento memento)
        {
            state = (List<string>)memento.Restore();
        }
    }
}
