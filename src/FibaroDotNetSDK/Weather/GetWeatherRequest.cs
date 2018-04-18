using System.Net.Http;
using FibaroDotNetSDK.Infrastructure;

namespace FibaroDotNetSDK.Weather
{
    public class GetWeatherRequest : RequestBase
    {
        public GetWeatherRequest() 
            : base(HttpMethod.Get, "/weather", null)
        {
        }
    }
}