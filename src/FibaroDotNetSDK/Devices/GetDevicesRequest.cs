using System.Net.Http;
using FibaroDotNetSDK.Infrastructure;

namespace FibaroDotNetSDK.Devices
{
    public class GetDevicesRequest : RequestBase
    {
        public GetDevicesRequest() 
            : base(HttpMethod.Get, "/devices", null)
        {
        }
    }
}