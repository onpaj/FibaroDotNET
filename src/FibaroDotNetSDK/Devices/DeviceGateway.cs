using System.Collections.Generic;
using System.Linq;
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

        public Task<ICollection<Device>> GetDevices()
        {
            var request = new GetDevicesRequest();
            return _client.SendRequest<ICollection<Device>>(request);
        }

        public Task<Device> GetDeviceById(int deviceId)
        {
            var request = new GetDeviceByIdRequest(deviceId);
            return _client.SendRequest<Device>(request);
        }

        public Task Call(long id, DeviceAction action)
        {
            var request = new CallDeviceActionRequest(id, action);
            return _client.SendRequest(request);
        }
    }
}