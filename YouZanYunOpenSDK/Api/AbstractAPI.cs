using System.Collections.Concurrent;
using System.Collections.Generic;
using YouZan.Open.Common.Constant;

namespace YouZan.Open.Api
{
    /// <summary>
    /// Api抽象类
    /// </summary>
    public abstract class AbstractApi : IApi
    {
        protected IApiParams ApiParams;

        protected string Gateway = "https://open.youzanyun.com";

        protected string Version;

        protected readonly IDictionary<string, string> Headers = new ConcurrentDictionary<string, string>();

        public void AddHeader(string headerName, string headerValue)
        {
            Headers.Add(headerName, headerValue);
        }

        public IApiParams GetAPIParams()
        {
            return ApiParams;
        }

        public void SetAPIParams(IApiParams apiParams)
        {
            this.ApiParams = apiParams;
        }

        public void SetGateway(string gateway)
        {
            Gateway = gateway;
        }

        public IDictionary<string, string> GetHeaders()
        {
            return Headers;
        }

        public string GetVersion()
        {
            return Version;
        }

       
        public abstract string GetGateway();
        public abstract OAuthEnum GetOAuthType();
        public abstract string GetHttpMethod();
        public abstract string GetName();
        public abstract string GetClientId();
        public abstract string GetGrantId();
    }
}
