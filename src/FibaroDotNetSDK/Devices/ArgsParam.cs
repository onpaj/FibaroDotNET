using Newtonsoft.Json;

namespace FibaroDotNetSDK.Devices
{
    public struct ArgsParam
    {
        [JsonProperty("args")]
        public string[] Args { get; }

        public ArgsParam(string[] args)
        {
            Args = args;
        }
    }
}