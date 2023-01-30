using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YouZan.Open.Api;
using YouZan.Open.Api.Constant;
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


        string IYouZanClient.Invoke(GeneralApi api, IAuth auth, IDictionary<string, string> headers, List<KeyValuePair<string, string>> files)
        {
            string url = null;
            if (api == null) return null;
            // OAuthEnum oAuth = api.GetOAuthType();
            switch (api.OAuthType)
            {
                case OAuthEnum.TOKEN:
                    url = BuildUrl(api, auth);
                    break;
                case OAuthEnum.SIGN:
                    break;
                case OAuthEnum.DIRECT:
                    url = BuildUrl(api, auth);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            // var apiParams = api.GetAPIParams();
            var requestParams = api.ApiParams.ToParams();
            // var header = api.GetHeaders();
            var result = defaultHttpClient.Send(url, requestParams, api.Headers, files);
            if (!YouZanConfig.SaveApiLogToDB) return result;
            var log = new YouZanLogger
            {
                ApiName = api.ServiceName,
                ApiVersion = api.Version,
                ApiMethod = api.HttpMethod,
                AuthType = api.OAuthType.ToString(),
                RequestUrl = url,
                PostData = JsonConvert.SerializeObject(requestParams),
                Header = JsonConvert.SerializeObject(api.Headers),
                ResponseData = result,
                ClientId = api.ClientId,
                GrantId = api.GrantId
            };
            Task.Run(log.Save);
            return result;
        }

        /**
         * 构建请求URL
         * 
         */
        private static string BuildUrl(GeneralApi api, IAuth auth)
        {
            string url;
            if (auth == null)
            {
                throw new ArgumentNullException(nameof(auth));
            }

            // var gateway = api.GetGateway();
            // var apiName = api.GetName();
            // var version = api.GetVersion();

            switch (auth)
            {
                case Token token:
                    return $"{ApiConst.HOST}/api/{api.ServiceName}/{api.Version}?access_token={token.GetToken()}";
                case Direct _:
                    return $"{ApiConst.HOST}/api/auth_exempt/{api.ServiceName}/{api.Version}";
                default:
                    return null;
            }
        }
    }
}

