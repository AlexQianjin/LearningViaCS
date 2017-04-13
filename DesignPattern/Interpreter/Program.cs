using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string rules = "COS333 L2 L2 L2 L2 L2 M25 (L40 T60 ) L10 E5 (L28 T73 ) ";
            int[][] values = new[] { new [] {80,0,100,100,85,51,52,50,57,56 },
                                     new [] {87,95,100,100,77,70,99,100,75,94 },
                                     new [] {0,55,100,65,55,75,73,74,71,72 } };
            Context context;
            Console.WriteLine(rules + "\n");

            context = new Context(rules);
            Element course = new Course(context);
            course.Parse(context);

            Console.WriteLine("Visitor 1 - Course structure\n");
            course.Print();

            course.Summarize();
            Console.WriteLine("\n\nVisitor 2 = Summing the weights\nLabs " + ElementExtensions.Lab + "% and Tests " + ElementExtensions.Test + "%");

            Console.WriteLine("\n\nVisitor 3 (Interpreter) ");
            foreach (int[] student in values)
            {
                Console.Write(student.Display());
                course.SetUp(context, student);
                course.Interpreter();
                Console.WriteLine(" = " + context.Output / 100);
            }

            Console.ReadLine();
        }
    }
}