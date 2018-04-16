using Newtonsoft.Json;

namespace FibaroDotNetSDK.Model.Device
{
    public partial class DeviceAction
    {
        [JsonProperty("abortUpdate")]
        public long AbortUpdate { get; set; }

        [JsonProperty("forceArm")]
        public long ForceArm { get; set; }

        [JsonProperty("meetArmConditions")]
        public long MeetArmConditions { get; set; }

        [JsonProperty("reconfigure")]
        public long Reconfigure { get; set; }

        [JsonProperty("retryUpdate")]
        public long RetryUpdate { get; set; }

        [JsonProperty("setArmed")]
        public long SetArmed { get; set; }

        [JsonProperty("setInterval")]
        public long SetInterval { get; set; }

        [JsonProperty("startUpdate")]
        public long StartUpdate { get; set; }

        [JsonProperty("updateFirmware")]
        public long UpdateFirmware { get; set; }
    }
}