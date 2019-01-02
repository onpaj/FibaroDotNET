using System.Net;
using System.Net.Http;
using FibaroDotNetSDK.Devices.Model;
using FibaroDotNetSDK.Infrastructure;

namespace FibaroDotNetSDK.Devices
{
    public class CallDeviceActionRequest : RequestBase
    {
        public CallDeviceActionRequest(long id, DeviceAction action)
            : base(HttpMethod.Post, $"/devices/{id}/action/{action.Name}", new ArgsParam(action.Args), HttpStatusCode.Accepted)
        {
        }
    }
}