using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Course : Element
    {
        public string Name { get; set; }

        public Course(Context context)
        {
            this.Name = context.Input.Substring(0, 6);
            context.Input = context.Input.Substring(7);
        }

        public override string Display()
        {
            return Name;
        }
    }
}
