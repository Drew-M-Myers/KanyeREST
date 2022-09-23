using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanyeREST
{
    public class RonSwansonQuoteGenerator
    {
        public static void RonSwansonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[',' ').Replace(']',' ').Trim();

            Console.WriteLine($"Ron: {ronQuote}");
        }
    }
}
