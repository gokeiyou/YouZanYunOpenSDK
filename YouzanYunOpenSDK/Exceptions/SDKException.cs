using System;
using System.Net;
using YouZan.Open.Common.Constant;

namespace YouZan.Open.Exceptions
{
    public class SDKException : Exception
    {
        private readonly int code;

        private readonly string message;
        private readonly HttpStatusCode statusCode;
        private readonly string v;

        public SDKException(int code, string message)
        {
            this.code = code;
            this.message = message;
        }

        public SDKException(HttpStatusCode statusCode, string v)
        {
            this.statusCode = statusCode;
            this.v = v;
        }
    }
}
