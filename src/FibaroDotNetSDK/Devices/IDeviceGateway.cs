using System.Collections.Generic;
using System.Threading.Tasks;
using FibaroDotNetSDK.Devices.Model;

namespace FibaroDotNetSDK.Devices
{
    public interface IDeviceGateway
    {
        Task<ICollection<Device>> GetDevices();
    }
}
