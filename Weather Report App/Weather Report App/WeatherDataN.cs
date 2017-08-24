using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Weather_Report_App
{

    internal partial class WeatherDataN
    {
        internal class Coord2
        {

            [JsonProperty("lon")]
            public double Lon { get; set; }

            [JsonProperty("lat")]
            public double Lat { get; set; }
        }
    }

    internal partial class WeatherDataN
    {
        internal class Weather2
        {

            [JsonProperty("id")]
            public double Id { get; set; }

            [JsonProperty("main")]
            public string Main { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }
        }
    }

    internal partial class WeatherDataN
    {
        internal class Main2
        {

            [JsonProperty("temp")]
            public double Temp { get; set; }

            [JsonProperty("pressure")]
            public double Pressure { get; set; }

            [JsonProperty("humidity")]
            public double Humidity { get; set; }

            [JsonProperty("temp_min")]
            public double TempMin { get; set; }

            [JsonProperty("temp_max")]
            public double TempMax { get; set; }
        }
    }

    internal partial class WeatherDataN
    {
        internal class Wind2
        {

            [JsonProperty("speed")]
            public double Speed { get; set; }

            [JsonProperty("deg")]
            public double Deg { get; set; }
        }
    }

    internal partial class WeatherDataN
    {
        internal class Clouds2
        {

            [JsonProperty("all")]
            public double All { get; set; }
        }
    }

    internal partial class WeatherDataN
    {
        internal class Sys2
        {

            [JsonProperty("type")]
            public double  Type { get; set; }

            [JsonProperty("id")]
            public double Id { get; set; }

            [JsonProperty("message")]
            public double Message { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("sunrise")]
            public double Sunrise { get; set; }

            [JsonProperty("sunset")]
            public double Sunset { get; set; }
        }
    }

    internal partial class WeatherDataN
    {

        [JsonProperty("coord")]
        public Coord2 Coord { get; set; }

        [JsonProperty("weather")]
        public Weather2[] Weather { get; set; }
        
        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("main")]
        public Main2 Main { get; set; }

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind2 Wind { get; set; }

        [JsonProperty("clouds")]
        public Clouds2 Clouds { get; set; }

        [JsonProperty("dt")]
        public double Dt { get; set; }

        [JsonProperty("sys")]
        public Sys2 Sys { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cod")]
        public double Cod { get; set; }
    }

}
