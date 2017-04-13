using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Context
    {
        public string Input { get; set; }
        public double Output { get; set; }

        public Context(string c)
        {
            this.Input = c;
            this.Output = 0;
        }
    }
}
