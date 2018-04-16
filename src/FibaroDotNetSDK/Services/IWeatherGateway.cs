using FibaroDotNetSDK.Model.Weather;

namespace FibaroDotNetSDK.Services
{
    public interface IWeatherGateway
    {
        Weather GetWeather();
    }
}