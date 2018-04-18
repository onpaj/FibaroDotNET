using System.Collections.Generic;
using Newtonsoft.Json;

namespace FibaroDotNetSDK.Scenes.Model
{
    public partial class SceneTrigger
    {
        [JsonProperty("properties")]
        public List<SceneProperty> Properties { get; set; }

        [JsonProperty("globals")]
        public List<object> Globals { get; set; }

        [JsonProperty("events")]
        public List<object> Events { get; set; }

        [JsonProperty("weather")]
        public List<object> Weather { get; set; }
    }
}