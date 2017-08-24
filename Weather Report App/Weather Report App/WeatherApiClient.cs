using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using Newtonsoft.Json;
namespace Weather_Report_App
{
    public static class WeatherApiClient
    {
        /// <summary>
        /// Gets the weather info
        /// </summary>
        /// <param name="City"></param>
        /// <returns></returns>
        internal static WeatherDataN GetWeather(string City)
        {
            try
            {
                var url = "http://api.openweathermap.org/data/2.5/weather?q=" + City + "&APPID=e0b03cfb93e71b9e09f0804d3f957769";

                var syncClient = new WebClient();

                var content = syncClient.DownloadString(url);

                return JsonConvert.DeserializeObject<WeatherDataN>(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
