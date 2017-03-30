using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Prototype
{
    [Serializable()]
    public class DeepData
    {
        public string Data { get; set; }

        public DeepData()
        {

        }

        public DeepData(string s)
        {
            this.Data = s;
        }

        public override string ToString()
        {
            return this.Data;
        }
    }
}
