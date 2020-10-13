using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;

namespace Sunrise_sunset_Api_Pautova
{
    class Program
    {
        private static string url = "https://api.sunrise-sunset.org/json?lat=59.4370&lng=24.7536&date=2020-10-13";
        static void Main(string[] args)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            var WebResponse = request.GetResponse();
            var WebStream = WebResponse.GetResponseStream();
            using (var responsereader = new StreamReader(WebStream))
            {
                var response = responsereader.ReadToEnd();
                SunMode sunMode = JsonConvert.DeserializeObject<SunMode>(response);
                Console.WriteLine($"Sunrise: {sunMode.Results.Sunrise}.");
                Console.WriteLine($"Sunset: {sunMode.Results.Sunrise}.");
                Console.WriteLine($"Status: {sunMode.Results.Sunrise}.");

            }
        }
    }
}
