using ConsumingServices.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingRestServices.Core
{
    public static class Services
    {
        public static async Task<WeatherResult> GetWeatherResults(double latitude, double longitude, int maxResults)
        {
            HttpClient client = new HttpClient();
            string url = "http://api.openweathermap.org/data/2.5/forecast/daily?lat={0}&lon={1}&cnt={2}&mode=json";
            url = string.Format(url, latitude, longitude, maxResults);

            string result = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<WeatherResult>(result);
        }
    }
}
