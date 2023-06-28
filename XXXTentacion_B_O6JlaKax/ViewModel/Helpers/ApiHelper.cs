using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XXXTentacion_B_O6JlaKax.Model;
using System.Windows;
using System.IO;

namespace XXXTentacion_B_O6JlaKax.ViewModel.Helpers
{
    static class ApiHelper
    {
        public static WeatherInfo getWeather(string city)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=cfcef6872ef1ebf9b1683779749b649d&lang=ru&units=metric");
            HttpResponseMessage response = httpClient.Send(request);
            try
            {
                WeatherInfo weatherInfo = new WeatherInfo(JsonConvert.DeserializeObject<JObject>(response.Content.ReadAsStringAsync().Result));
                return weatherInfo;
            }
            catch
            {
                return new WeatherInfo();
            }
        }

        public static List<CityInfo> getFavour()
        {
            return JsonConvert.DeserializeObject<List<CityInfo>>(File.ReadAllText("favours.json")); ;
        }

        public static void startUpdater()
        {

        }
    }
}
