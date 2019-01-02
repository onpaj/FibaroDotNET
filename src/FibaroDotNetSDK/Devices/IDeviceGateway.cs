using System.Collections.Generic;
using System.Threading.Tasks;
using FibaroDotNetSDK.Devices.Model;
using System.Linq;

namespace FibaroDotNetSDK.Devices
{
    public interface IDeviceGateway
    {
        Task<ICollection<Device>> GetDevices(bool force = false);

        Task<Device> GetDevice(long id);
        Task Call(long id, DeviceAction action);
    }

    public class CacheDeviceGatewayDecorator : IDeviceGateway
    {
        private readonly IDeviceGateway _decorated;

        public CacheDeviceGatewayDecorator(IDeviceGateway decorated)
        {
            _decorated = decorated;
        }


        private ICollection<Device> _devices = null;
        public async Task<ICollection<Device>> GetDevices(bool force = false)
        {
            if (_devices == null || force)
            {
                _devices = await _decorated.GetDevices();
            }

            return _devices;
        }

        public async Task<Device> GetDevice(long id)
        {
            var devices = await GetDevices();
    
            return devices.Single(w => w.Id == id);
        }

        public async Task Call(long id, DeviceAction action)
        {
            await _decorated.Call(id, action);

            var device = _devices?.SingleOrDefault(w => w.Id == id);
            if (device != null)
            {
                ApplyActionLocally(device, action);
            }
        }

        private void ApplyActionLocally(Device device, DeviceAction action)
        {
            switch (action.Name)
            {
                case "setValue":
                case "setTargetLevel":
                    device.Properties.Value = action.Args.First();
                    break;
            }
        }
    }
}
