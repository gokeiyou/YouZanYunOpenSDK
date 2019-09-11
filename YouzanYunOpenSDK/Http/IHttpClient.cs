using System;
using System.Collections.Generic;
using System.Net.Http;
using YouZan.Open.Api;
using YouZan.Open.Auth;

namespace YouZan.Open.Http
{
    public interface IHttpClient
    {

        /**
         * 发送请求接口
         */
        string Send(string url, IDictionary<string, object> apiParams, IDictionary<string, string> headers, List<KeyValuePair<string, string>> files);
    }
}
