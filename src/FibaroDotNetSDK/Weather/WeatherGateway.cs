using System.Net;
using System.Threading.Tasks;
using FibaroDotNetSDK.Infrastructure;

namespace FibaroDotNetSDK.Weather
{
    public class WeatherGateway : IWeatherGateway
    {
        private readonly HomeCenterFibaroClient _client;

        public WeatherGateway(HomeCenterFibaroClient client)
        {
            _client = client;
        }

        public Task<Model.Weather> GetWeather()
        {
            var request = new GetWeatherRequest();

            return _client.SendRequest<Model.Weather>(request);
        }
    }
}