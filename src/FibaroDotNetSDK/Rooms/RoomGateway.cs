using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FibaroDotNetSDK.Infrastructure;
using FibaroDotNetSDK.Rooms.Model;

namespace FibaroDotNetSDK.Rooms
{
    public class RoomGateway : IRoomGateway
    {
        private readonly IFibaroClient _client;

        public RoomGateway(IFibaroClient client)
        {
            _client = client;
        }

        public Task<ICollection<Room>> GetRooms()
        {
            var request = new GetRoomsRequest();

            return _client.SendRequest<ICollection<Room>>(request);
        }
    }
}