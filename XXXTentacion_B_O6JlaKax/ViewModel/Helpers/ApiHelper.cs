using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace XXXTentacion_B_O6JlaKax.ViewModel.Helpers
{
    static class ApiHelper
    {
        public static JObject getWeather(string city)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=cfcef6872ef1ebf9b1683779749b649d&lang=ru&units=metric");
            HttpResponseMessage response = httpClient.Send(request);

            return JsonConvert.DeserializeObject<JObject>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
