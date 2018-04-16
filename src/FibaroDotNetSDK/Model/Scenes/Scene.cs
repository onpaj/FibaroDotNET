using System.Collections.Generic;
using Newtonsoft.Json;

namespace FibaroDotNetSDK.Model.Scenes
{
    public partial class Scene
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("roomID")]
        public long RoomId { get; set; }

        [JsonProperty("runConfig")]
        public string RunConfig { get; set; }

        [JsonProperty("alexaProhibited")]
        public bool AlexaProhibited { get; set; }

        [JsonProperty("autostart")]
        public bool Autostart { get; set; }

        [JsonProperty("protectedByPIN")]
        public bool ProtectedByPin { get; set; }

        [JsonProperty("killable")]
        public bool Killable { get; set; }

        [JsonProperty("killOtherInstances")]
        public bool KillOtherInstances { get; set; }

        [JsonProperty("maxRunningInstances")]
        public long MaxRunningInstances { get; set; }

        [JsonProperty("runningInstances")]
        public long RunningInstances { get; set; }

        [JsonProperty("instances")]
        public List<string> Instances { get; set; }

        [JsonProperty("runningManualInstances")]
        public long RunningManualInstances { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("properties")]
        public string Properties { get; set; }

        [JsonProperty("triggers")]
        public SceneTrigger Triggers { get; set; }

        [JsonProperty("actions")]
        public SceneAction Actions { get; set; }

        [JsonProperty("liliStartCommand")]
        public string LiliStartCommand { get; set; }

        [JsonProperty("liliStopCommand")]
        public string LiliStopCommand { get; set; }

        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }
    }
}
