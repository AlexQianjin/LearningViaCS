using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

using LearningViaCS.Domain.Model;

namespace LearningViaCS
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please input file name");
                return;
            }

            string currentPath = AppContext.BaseDirectory;
            string path = currentPath + $"\\{args[0]}";
            string inputFile = File.ReadAllText(path);
            string outputPath = currentPath + $"\\_{args[0]}";
            string input = "obj.Select strValue";
            string parttern = "(?<base>\\w+\\.\\w+)\\s(?<name>\\w+)";
            string replacement = "${base}(${name})";
            if (Regex.IsMatch(input,parttern))
            {
                input = Regex.Replace(input, parttern, replacement);
            }
            Console.WriteLine(input);

            using (FileStream fs = new FileStream(outputPath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write("--" + inputFile.ToString());
                    sw.Flush();
                }
            }

            ////Console.OutputEncoding = Encoding.Unicode;
            //string url = "http://quotes.money.163.com/hs/service/diyrank.php?host=http%3A%2F%2Fquotes.money.163.com%2Fhs%2Fservice%2Fdiyrank.php&page=0&query=STYPE%3AEQA%3BEXCHANGE%3ACNSESH&fields=NO%2CSYMBOL%2CNAME%2CPRICE%2CPERCENT%2CUPDOWN%2CFIVE_MINUTE%2COPEN%2CYESTCLOSE%2CHIGH%2CLOW%2CVOLUME%2CTURNOVER%2CHS%2CLB%2CWB%2CZF%2CPE%2CMCAP%2CTCAP%2CMFSUM%2CMFRATIO.MFRATIO2%2CMFRATIO.MFRATIO10%2CSNAME%2CCODE%2CANNOUNMT%2CUVSNEWS&sort=PERCENT&order=desc&count=100&type=query";
            //HttpClient client = new HttpClient();
            //client.GetAsync(url).ContinueWith(requestTask =>
            //{
            //    HttpResponseMessage response = requestTask.Result;
            //    response.EnsureSuccessStatusCode();

            //    response.Content.ReadAsStringAsync().ContinueWith(readTask =>
            //    {
            //        string content = readTask.Result;
            //        JsonResult jsonObject = JsonConvert.DeserializeObject<JsonResult>(content);
            //        var items = jsonObject.Stocks.FindAll(s => s.Percent > 0.05);
            //        StringBuilder sb = new StringBuilder();
            //        items.ForEach(s =>
            //        {
            //            sb.AppendLine($"{s.Symbol} {s.SName} {s.Percent} {s.Price}");
            //            Console.WriteLine($"{s.Symbol} {s.SName} {s.Percent} {s.Price}");
            //        });
            //        string path = AppContext.BaseDirectory + "\\result.txt";
            //        using (FileStream fs = new FileStream(path, FileMode.Create))
            //        {
            //            using (StreamWriter sw = new StreamWriter(fs))
            //            {
            //                sw.Write(sb.ToString());
            //                sw.Flush();
            //            }
            //        }
            //    });
            //});

            Console.WriteLine(inputFile);
            Console.ReadLine();
        }
    }
}