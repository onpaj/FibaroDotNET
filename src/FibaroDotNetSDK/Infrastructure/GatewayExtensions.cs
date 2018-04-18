using System;
using System.Linq;
using System.Threading.Tasks;
using FibaroDotNetSDK.Devices;
using FibaroDotNetSDK.Devices.Model;

namespace FibaroDotNetSDK.Infrastructure
{
    public static class GatewayExtensions
    {
        public static async Task<Device> GetDevice(this IDeviceGateway gateway, Func<Device, bool> predicate)
        {
            var devices = await gateway.GetDevices();
                
            return devices.SingleOrDefault(predicate);
        }
    }
}