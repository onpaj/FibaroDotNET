using Newtonsoft.Json;

namespace FibaroDotNetSDK.Weather.Model
{
    public partial class Weather
    {
        [JsonProperty("Temperature")]
        public double Temperature { get; set; }

        [JsonProperty("TemperatureUnit")]
        public string TemperatureUnit { get; set; }

        [JsonProperty("Humidity")]
        public double Humidity { get; set; }

        [JsonProperty("Wind")]
        public double Wind { get; set; }

        [JsonProperty("WindUnit")]
        public string WindUnit { get; set; }

        [JsonProperty("WeatherCondition")]
        public string WeatherCondition { get; set; }

        [JsonProperty("ConditionCode")]
        public long ConditionCode { get; set; }
    }
}
