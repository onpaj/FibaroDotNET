using System.Linq;
using Newtonsoft.Json;

namespace FibaroDotNetSDK.Devices.Model
{
    public struct DeviceAction
    {
        public DeviceAction(string name, params object[] args)
        {
            Name = name;
            Args = args.Select(s => s.ToString()).ToArray();
        }

        public string Name { get; }

        public string[] Args { get; }
    }
}