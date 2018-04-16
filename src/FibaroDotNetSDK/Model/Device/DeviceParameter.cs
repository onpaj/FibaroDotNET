using Newtonsoft.Json;

namespace FibaroDotNetSDK.Model.Device
{
    public partial class DeviceParameter
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("lastReportedValue")]
        public long LastReportedValue { get; set; }

        [JsonProperty("lastSetValue")]
        public long LastSetValue { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }
}