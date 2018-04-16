using System;
using System.Collections.Generic;
using System.Text;
using FibaroDotNetSDK.Model.Device;

namespace FibaroDotNetSDK.Services
{
    public interface IDeviceGateway
    {
        ICollection<Device> GetDevices();

        Device GetDevice(Func<Device, bool> deviceProdicate);
    }
}
