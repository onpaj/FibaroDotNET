using System.Net.Http;
using FibaroDotNetSDK.Infrastructure;

namespace FibaroDotNetSDK.Devices
{
    public class GetDeviceByIdRequest : RequestBase
    {
        public GetDeviceByIdRequest(int deviceId)
            : base(HttpMethod.Get, $"/devices/{deviceId}", null)
        {
        }
    }
}
