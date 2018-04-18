using Newtonsoft.Json;

namespace FibaroDotNetSDK.Rooms.Model
{
    public partial class Room
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sectionID")]
        public long SectionId { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("defaultSensors")]
        public DefaultSensors DefaultSensors { get; set; }

        [JsonProperty("defaultThermostat")]
        public long DefaultThermostat { get; set; }

        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }
    }
}
