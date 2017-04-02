﻿using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

using LearningViaCS.Domain.Model;

namespace LearningViaCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.Unicode;
            string url = "http://quotes.money.163.com/hs/service/diyrank.php?host=http%3A%2F%2Fquotes.money.163.com%2Fhs%2Fservice%2Fdiyrank.php&page=0&query=STYPE%3AEQA%3BEXCHANGE%3ACNSESH&fields=NO%2CSYMBOL%2CNAME%2CPRICE%2CPERCENT%2CUPDOWN%2CFIVE_MINUTE%2COPEN%2CYESTCLOSE%2CHIGH%2CLOW%2CVOLUME%2CTURNOVER%2CHS%2CLB%2CWB%2CZF%2CPE%2CMCAP%2CTCAP%2CMFSUM%2CMFRATIO.MFRATIO2%2CMFRATIO.MFRATIO10%2CSNAME%2CCODE%2CANNOUNMT%2CUVSNEWS&sort=PERCENT&order=desc&count=100&type=query";
            HttpClient client = new HttpClient();
            client.GetAsync(url).ContinueWith(requestTask =>
            {
                HttpResponseMessage response = requestTask.Result;
                response.EnsureSuccessStatusCode();

                response.Content.ReadAsStringAsync().ContinueWith(readTask =>
                {
                    string content = readTask.Result;
                    JsonResult jsonObject = JsonConvert.DeserializeObject<JsonResult>(content);
                    var items = jsonObject.Stocks.FindAll(s => s.Percent > 0.05);
                    StringBuilder sb = new StringBuilder();
                    items.ForEach(s =>
                    {
                        sb.AppendLine($"{s.Symbol} {s.SName} {s.Percent} {s.Price}");
                        Console.WriteLine($"{s.Symbol} {s.SName} {s.Percent} {s.Price}");
                    });
                    string path = AppContext.BaseDirectory + "\\result.txt";
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            sw.Write(sb.ToString());
                            sw.Flush();
                        }
                    }
                });
            });

            Console.ReadLine();
        }
    }
}