using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Prototype
{
    [Serializable()]
    public class PrototypeManager : IPrototype<Prototype>
    {
        public Dictionary<string, Prototype> prototypes = new Dictionary<string, Prototype>
        {
            {"Germany", new Prototype("Germany", "Berlin", "German")},
            {"Italy", new Prototype("Italy", "Rome", "Italian")},
            {"Australia", new Prototype("Australia", "Canberra", "English") }
        };
    }
}
