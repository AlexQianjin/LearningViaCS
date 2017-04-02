using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LearningViaCS.Domain.Model
{
    public class Stock
    {
        public List<Announmt> Announmt { get; set; }

        public string Code { get; set; }

        [JsonProperty("FIVE_MINUTE")]
        public double FiveMinute { get; set; }

        public double High { get; set; }

        public double HS { get; set; }

        public double Low { get; set; }

        public double Mcap { get; set; }

        public Mfratio Mfratio { get; set; }

        public double MfSum { get; set; }

        public string Name { get; set; }

        public double Open { get; set; }

        public double Percent { get; set; }

        public double Price { get; set; }

        public string SName { get; set; }

        public string Symbol { get; set; }

        public double Tcap { get; set; }

        public double TurnOver { get; set; }

        public double UpDown { get; set; }
        
        public int Volume { get; set; }

        public double Wb { get; set; }

        public double YestClose { get; set; }

        public double Zf { get; set; }

        public int No { get; set; }
    }
}
