using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Element
    {
        public int Weight { get; set; }
        public Element Next { get; set; }
        public Element Part { get; set; }

        public virtual string Display()
        {
            return this.Weight + "%";
        }

        private int GetNumber(Context context)
        {
            int atSpace = context.Input.IndexOf(' ');
            int number = Int32.Parse(context.Input.Substring(1, atSpace));
            context.Input = context.Input.Substring(atSpace + 1);

            return number;
        }

        public void Parse(Context context)
        {
            string starters = "LTME";
            if (context.Input.Length>0&&starters.IndexOf(context.Input[0])>=0)
            {
                switch (context.Input[0])
                {
                    case 'L':
                        Next = new Lab();
                        break;
                    case 'T':
                        Next = new Test();
                        break;
                    case 'M':
                        Next = new Midterm();
                        break;
                    case 'E':
                        Next = new Exam();
                        break;
                    default:
                        break;
                }
                Next.Weight = GetNumber(context);
                if (context.Input.Length>0&&context.Input[0]=='(')
                {
                    context.Input = context.Input.Substring(1);
                    Next.Part = new Element();
                    Next.Part.Parse(context);
                    Element e = Next.Part;
                    while (e!=null)
                    {
                        e.Weight = e.Weight * Next.Weight / 100;
                        e = e.Next;
                    }
                    context.Input = context.Input.Substring(2);
                }
                Next.Parse(context);
            }
        }
    }
}
