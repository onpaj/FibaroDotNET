using System.Collections.Generic;
using Newtonsoft.Json;

namespace FibaroDotNetSDK.Devices.Model
{
    public partial class Device
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roomID")]
        public long RoomId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("baseType")]
        public string BaseType { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("isPlugin")]
        public bool IsPlugin { get; set; }

        [JsonProperty("parentId")]
        public long ParentId { get; set; }

        [JsonProperty("remoteGatewayId")]
        public long RemoteGatewayId { get; set; }

        [JsonProperty("interfaces")]
        public List<string> Interfaces { get; set; }

        [JsonProperty("properties")]
        public DeviceProperty Properties { get; set; }

        [JsonProperty("actions")]
        public DeviceAction Actions { get; set; }

        [JsonProperty("created")]
        public long Created { get; set; }

        [JsonProperty("modified")]
        public long Modified { get; set; }

        [JsonProperty("sortOrder")]
        public long SortOrder { get; set; }
    }
}
