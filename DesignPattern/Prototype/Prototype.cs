using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Prototype
{
    [Serializable()]
    public class Prototype : IPrototype<Prototype>
    {
        public string Country { get; set; }
        public string Capital { get; set; }
        public DeepData Language { get; set; }

        public Prototype()
        {

        }

        public Prototype(string country, string capital, string language)
        {
            this.Country = country;
            this.Capital = capital;
            this.Language = new DeepData(language);
        }

        public override string ToString()
        {
            //return this.Country + "\t\t" + this.Capital + "\t\t" + this.Language;
            return $"'{this.Country}'\t\t{this.Capital}\t\t{this.Language}";
        }
    }
}
