using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static FlyweightFactory album = new FlyweightFactory();

        static Dictionary<string, List<string>> allGroups = new Dictionary<string, List<string>>();

        public void LoadGroups()
        {
            var myGroups = new[] {
                new {Name = "Garden", Members = new [] {"pot.jpg", "spring.jpg", "barbeque.jpg", "flower.jpg" } },
                new {Name = "Italy", Members = new [] {"cappucino.jpg", "pasta.jpg", "restaurant.jpg", "church.jpg" } },
                new {Name = "Food", Members = new [] { "pasta.jpg", "veggies.jpg", "barbeque.jpg", "cappucino.jpg", "lemonade.jpg" } },
                new {Name = "Friends", Members = new [] { "restaurant.jpg", "dinner.jpg" } }
            };

            foreach (var g in myGroups)
            {
                allGroups.Add(g.Name, new List<string>());
                foreach (string filename in g.Members)
                {
                    allGroups[g.Name].Add(filename);
                    album[filename].Load(filename);
                }
            }
        }

        public void DisplayGroups(Object source, PaintEventArgs e)
        {
            int row;
            foreach (string g in allGroups.Keys)
            {
                int col;
                //e.Graphics.DrawString(g,new Font("Arial", 16), new SolidBrush(Color.Black), new PointF(0, row*130 + 10));
                row = 0;
                col = 0;
                foreach (string filename in allGroups[g])
                {
                    album[filename].Display(e, row, col);
                    col++;
                }
                row++;
            }
        }
    }
}