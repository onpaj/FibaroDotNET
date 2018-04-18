using Newtonsoft.Json;

namespace FibaroDotNetSDK.Scenes.Model
{
    public partial class SceneProperty
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}