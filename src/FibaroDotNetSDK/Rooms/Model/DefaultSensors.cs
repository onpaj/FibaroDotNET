using Newtonsoft.Json;

namespace FibaroDotNetSDK.Rooms.Model
{
    public partial class DefaultSensors
    {
        [JsonProperty("temperature")]
        public long Temperature { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        [JsonProperty("light")]
        public long Light { get; set; }
    }
}