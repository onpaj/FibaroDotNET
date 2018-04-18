using System.Net.Http;
using FibaroDotNetSDK.Infrastructure;

namespace FibaroDotNetSDK.Scenes
{
    public class GetScenesRequest : RequestBase
    {
        public GetScenesRequest() 
            : base(HttpMethod.Get, "/scenes", null)
        {
        }
    }
}