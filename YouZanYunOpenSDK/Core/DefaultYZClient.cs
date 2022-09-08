using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YouZan.Open.Api;
using YouZan.Open.Auth;
using YouZan.Open.Common.Constant;
using YouZan.Open.Http;
using YouZan.Open.Log;
using YouZan.Open.TokenEx;

namespace YouZan.Open.Core
{
    public class DefaultYZClient : IYouZanClient
    {
        private readonly DefaultHttpClient defaultHttpClient;

        public DefaultYZClient()
        {
            this.defaultHttpClient = new DefaultHttpClient();
        }


        string IYouZanClient.Invoke(IApi api, IAuth auth, IDictionary<string, string> headers, List<KeyValuePair<string, string>> files)
        {
            string url = null;
            if (api != null)
            {
                OAuthEnum oAuth = api.GetOAuthType();
                switch (oAuth)
                {
                    case OAuthEnum.TOKEN:
                        url = BuildUrl(api, auth);
                        break;
                    case OAuthEnum.SIGN:
                        break;
                    case OAuthEnum.DIRECT:
                        url = BuildUrl(api, auth);
                        break;

                }
                IApiParams apiParams = api.GetAPIParams();
                IDictionary<string, object> requestParams = apiParams.ToParams();
                IDictionary<string, string> header = api.GetHeaders();
                string result = defaultHttpClient.Send(url, requestParams, header, files);
                if (YouZanConfig.SaveApiLogToDB)
                {
                    YouZanLogger log = new YouZanLogger
                    {
                        ApiName = api.GetName(),
                        ApiVersion = api.GetVersion(),
                        ApiMethod = api.GetHttpMethod(),
                        AuthType = oAuth.ToString(),
                        RequestUrl = url,
                        PostData = JsonConvert.SerializeObject(requestParams),
                        Header = JsonConvert.SerializeObject(header),
                        ResponseData = result,
                        ClientId = api.GetClientId(),
                        GrantId = api.GetGrantId()
                    };
                    Task.Run(log.Save);
                }
                return result;
            }
            return null;
        }

        /**
         * 构建请求URL
         * 
         */
        private string BuildUrl(IApi api, IAuth auth)
        {
            string url = null;
            if (auth == null)
            {
                throw new ArgumentNullException(nameof(auth));
            }

            var gateway = api.GetGateway();
            var apiName = api.GetName();
            var version = api.GetVersion();

            switch (auth)
            {
                case Token token:
                    url = $"{gateway}/api/{apiName}/{version}?access_token={token.GetToken()}";
                    break;
                case Direct _:
                    url = $"{gateway}/api/auth_exempt/{apiName}/{version}";
                    break;
            }

            return url;
        }


    }
}

