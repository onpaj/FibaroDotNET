using System.Threading.Tasks;

namespace FibaroDotNetSDK.Weather
{
    public interface IWeatherGateway
    {
        Task<Model.Weather> GetWeather();
    }
}