using System.Threading.Tasks;

namespace FibaroDotNetSDK.Infrastructure
{
    public interface IFibaroClient
    {
        Task<T> SendRequest<T>(RequestBase request);
        Task SendRequest(RequestBase request);
    }
}