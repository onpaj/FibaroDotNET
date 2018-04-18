using System.Net;
using System.Net.Http;

namespace FibaroDotNetSDK.Infrastructure
{
    public abstract class RequestBase 
    {
        protected RequestBase(HttpMethod method, string path, object body, HttpStatusCode expectedStatus = HttpStatusCode.OK)
        {
            Method = method;
            Path = path;
            Body = body;
            ExpectedStatus = expectedStatus;
        }

        public HttpMethod Method { get; }
        public string Path { get; }
        public object Body { get; }
        public HttpStatusCode ExpectedStatus { get; }
    }
}