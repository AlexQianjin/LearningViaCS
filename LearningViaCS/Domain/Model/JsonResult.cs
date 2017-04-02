using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LearningViaCS.Domain.Model
{
    public class JsonResult
    {
        public int Page { get; set; }

        public int Count { get; set; }

        public string Order { get; set; }

        public int Total { get; set; }

        public int PageCount { get; set; }

        public string Time { get; set; }

        [JsonProperty("list")]
        public List<Stock> Stocks { get; set; }
    }
}
