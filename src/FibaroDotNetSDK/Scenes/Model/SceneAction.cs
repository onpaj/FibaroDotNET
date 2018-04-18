using System.Collections.Generic;
using Newtonsoft.Json;

namespace FibaroDotNetSDK.Scenes.Model
{
    public partial class SceneAction
    {
        [JsonProperty("devices")]
        public List<long> Devices { get; set; }

        [JsonProperty("scenes")]
        public List<object> Scenes { get; set; }

        [JsonProperty("groups")]
        public List<object> Groups { get; set; }
    }
}