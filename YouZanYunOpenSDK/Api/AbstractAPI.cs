using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using YouZan.Open.Api.Constant;
using YouZan.Open.Common.Constant;

namespace YouZan.Open.Api
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractAPI : IAPI
    {
        protected IApiParams apiParams;

        protected string _Gateway = "https://open.youzanyun.com";

        protected string _Version;

        protected IDictionary<string, string> headers = new ConcurrentDictionary<string, string>();

        public void AddHeader(string headerName, string headerValue)
        {
            headers.Add(headerName, headerValue);
        }

        public IApiParams GetAPIParams()
        {
            return apiParams;
        }

        public void SetAPIParams(IApiParams apiParams)
        {
            this.apiParams = apiParams;
        }

        public void SetGateway(string gateway = API.GATEWAY)
        {
            this._Gateway = gateway;
        }

        public IDictionary<string, string> GetHeaders()
        {
            return headers;
        }

        public string GetVersion()
        {
            return _Version;
        }

       
        public abstract string GetGateway();
        public abstract OAuthEnum GetOAuthType();
        public abstract string GetHttpMethod();
        public abstract string GetName();
        public abstract string GetClientId();
        public abstract string GetGrantId();
    }
}
