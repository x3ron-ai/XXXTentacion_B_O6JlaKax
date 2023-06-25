using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XXXTentacion_B_O6JlaKax.Model
{
    public class WeatherInfo
    {
        public WeatherInfo(JObject data)
        {
            name = Convert.ToString(data["weather"][0]["main"]);
            description = Convert.ToString(data["weather"][0]["description"]);
            temp = Convert.ToDouble(data["main"]["temp"]);
            temp_feels = Convert.ToDouble(data["main"]["feels_like"]);
            wind_speed = Convert.ToDouble(data["wind"]["speed"]);
            humidity = Convert.ToDouble(data["main"]["humidity"]);
        }

        public string name { get; set; }
        public string description { get; set; }
        public double temp { get; set; } 
        public double temp_feels { get; set; }
        public double wind_speed { get; set; }
        public double humidity { get; set; }

    }
}
