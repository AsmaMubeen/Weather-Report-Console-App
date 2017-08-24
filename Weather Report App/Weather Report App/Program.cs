using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Weather_Report_App
{
    class Program
    {
        /// <summary>
        /// Entry point of the application
        /// </summary>
        /// <param name="args">First argument should be the city for which the weather is required</param>
        static void Main(string[] args)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                if (args.Length > 0)
                {
                    var d = WeatherApiClient.GetWeather(args[0]);
                    if (d != null)
                    {
                        Console.WriteLine($"City: {d.Name}");
                        Console.WriteLine("Temperature = " + d.Main.Temp);
                        Console.WriteLine("Min Temperature = " + d.Main.TempMin);
                        Console.WriteLine("Max Temperature = " + d.Main.TempMax);
                        Console.WriteLine("Pressure = " + d.Main.Pressure + "hpa");
                        Console.WriteLine("Humidity = " + d.Main.Humidity + "%");
                        Console.WriteLine("Wind Speed = " + d.Wind.Speed + "m/s");
                        Console.WriteLine("Clouds :  " + d.Clouds.All + "%");
                    }
                }
                else
                    Console.WriteLine("No argument passed, Please provide the city name as the first argument.");
            }
            else
                Console.WriteLine("No network connection");
        }
    }
}
