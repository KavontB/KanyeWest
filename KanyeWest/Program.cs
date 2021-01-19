using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            int counter = 0;
            while (counter < 6)
            {
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var ronResponse = client.GetStringAsync(ronURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            
                counter++;
                Console.WriteLine($"Ron: {ronQuote}");
                Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-");
                Console.WriteLine($"Kanye: {kanyeQuote}");
                Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-");
            }
        }
        public static IRestResponse CallOfDuty()
        {
            var client = new RestClient("https://call-of-duty-modern-warfare.p.rapidapi.com/multiplayer/Chob%252321309/battle");

            var request = new RestRequest(Method.GET);

            request.AddHeader("x-rapidapi-key", "SIGN-UP-FOR-KEY");

            request.AddHeader("x-rapidapi-host", "call-of-duty-modern-warfare.p.rapidapi.com");

            IRestResponse response = client.Execute(request);

            return response;
        }
    }
}
