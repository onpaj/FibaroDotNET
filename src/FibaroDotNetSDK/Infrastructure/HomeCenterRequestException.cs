using System;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;

namespace FibaroDotNetSDK.Infrastructure
{
    public class HomeCenterRequestException : ApplicationException
    {

        public HomeCenterRequestException(HttpStatusCode statusCode, string message, HttpRequestMessage httpReq)
            :base(FormatMessage(statusCode, message, httpReq))
        {
            StatusCode = statusCode;
            HttpReq = httpReq;
        }

      

        public HttpStatusCode StatusCode { get; }
        public HttpRequestMessage HttpReq { get; }

        private static string FormatMessage(HttpStatusCode statusCode, string message, HttpRequestMessage httpReq)
        {
            return $"Call {httpReq.RequestUri} failed with {(int) statusCode} ({statusCode.ToString()}): {message}";
        }
    }
}