using System.Collections.Generic;
using System.Threading.Tasks;
using FibaroDotNetSDK.Rooms.Model;

namespace FibaroDotNetSDK.Rooms
{
    public interface IRoomGateway
    {
        Task<ICollection<Room>> GetRooms();
    }
}