using System.Collections.Generic;
using System.Threading.Tasks;
using FibaroDotNetSDK.Devices.Model;
using System.Linq;

namespace FibaroDotNetSDK.Devices
{
    public interface IDeviceGateway
    {
        Task<ICollection<Device>> GetDevices();
        Task<Device> GetDeviceById(int deviceId);

        Task Call(long id, DeviceAction action);
    }
}
