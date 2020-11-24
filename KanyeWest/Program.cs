using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            string chuck = "https://api.chucknorris.io/jokes/random";

            var chuckResponse = client.GetStringAsync(chuck).Result;

            Console.WriteLine(chuckResponse);

            var chuckQuote = JObject.Parse(chuckResponse).GetValue("value").ToString();

            Console.WriteLine(chuckQuote);
        }
    }
}
