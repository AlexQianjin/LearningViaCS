using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Caretaker[] c = new Caretaker[10];
            Originator originator = new Originator();

            int move = 0;

            Simulator simulator = new Simulator();

            foreach (string command in simulator)
            {
                if (command[0]=='*'&&move>0)
                {
                    originator.GetMemento(c[move - 1].Memento);
                }
                else
                {
                    originator.Operation(command);
                }
                move++;
                c[move] = new Caretaker();
                c[move].Memento = originator.SetMemento();
            }

            Console.ReadLine();
        }
    }
}