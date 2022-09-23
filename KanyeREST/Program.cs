using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeREST
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                KanyeQuoteGenerator.KanyeQuote();
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                RonSwansonQuoteGenerator.RonSwansonQuote();
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
    }
}