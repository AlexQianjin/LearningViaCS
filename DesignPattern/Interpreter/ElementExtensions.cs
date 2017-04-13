using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public static class ElementExtensions
    {
        public static string gap;

        public static void Print(this Element element)
        {
            Console.WriteLine(gap + element + " " + element.Weight);
            if (element.Part != null)
            {
                gap += "  ";
                Print(element.Part.Next);
                gap = gap.Substring(2);
            }
            if (element.Next != null)
            {
                Print(element.Next);
            }
        }

        public static int Lab { get; set; }
        public static int Test { get; set; }

        public static void Summarize(this Element element)
        {
            if (element is Lab)
            {
                Lab += element.Weight;
            }
            else if (element is Test)
            {
                Test += element.Weight;
            }
            else if ((element is Midterm || element is Exam) && element.Part == null)
            {
                Test += element.Weight;
            }
            if (element.Part != null)
            {
                Summarize(element.Part.Next);
            }
            if (element.Next != null)
            {
                Summarize(element.Next);
            }
        }

        public static int[] values;
        public static int n;
        public static Context context;

        public static void SetUp(this Element element, Context c, int[] v)
        {
            context = c;
            context.Output = 0;
            values = v;
            n = 0;
        }

        public static void Interpreter(this Element element)
        {
            if (element is Lab || element is Test)
            {
                context.Output += values[0] * element.Weight;
                n++;
            }

            if (element.Part != null)
            {
                Interpreter(element.Part.Next);
            }

            if (element.Next != null)
            {
                Interpreter(element.Next);
            }
        }
    }
}
