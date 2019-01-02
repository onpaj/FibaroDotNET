using System.Collections.Generic;
using System.Threading.Tasks;
using FibaroDotNetSDK.Devices.Model;
using FibaroDotNetSDK.Infrastructure;

namespace FibaroDotNetSDK.Devices
{
    public class DeviceGateway : IDeviceGateway
    {
        private readonly IFibaroClient _client;

        public DeviceGateway(IFibaroClient client)
        {
            _client = client;
        }

        public Task<ICollection<Device>> GetDevices(bool force = false)
        {
            var request = new GetDevicesRequest();
            return _client.SendRequest<ICollection<Device>>(request);
        }

        public Task<Device> GetDevice(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task Call(long id, DeviceAction action)
        {
            var request = new CallDeviceActionRequest(id, action);
            return _client.SendRequest(request);
        }
    }
}