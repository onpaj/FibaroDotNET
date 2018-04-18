using System.Net.Http;
using FibaroDotNetSDK.Infrastructure;

namespace FibaroDotNetSDK.Rooms
{
    public class GetRoomsRequest : RequestBase
    {
        public GetRoomsRequest()
            : base(HttpMethod.Get, "/rooms", null)
        {
        }
    }
}