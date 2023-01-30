using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using YouZan.Open.Api.Constant;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Response;
using YouZan.Open.Auth;
using YouZan.Open.Common.Constant;
using YouZan.Open.Core;
using YouZan.Open.TokenEx;
using static YouZan.Open.TokenEx.OauthToken;

namespace YouZan.Open.Api
{
    public partial class ApiHelper
    {
        /// <summary>
        /// 客户端ID
        /// </summary>
        private string ClientId { get; }

        /// <summary>
        /// 客户端密码
        /// </summary>
        private string ClientSecret { get; }
        /// <summary>
        /// 店铺ID
        /// </summary>
        private string GrantId { get; }

        private readonly IYouZanClient _youZanClient;
        private TokenData _oAuthToken;

        private readonly bool _checkToken;
        private readonly Func<TokenData> _funcGetTokenData;

        /// <summary>
        /// 初始化，直接传入TokenData
        /// </summary>
        /// <param name="tokenData">token</param>
        /// <param name="funcGetTokenData">获取新TokenData的委托</param>
        public ApiHelper(TokenData tokenData, Func<TokenData> funcGetTokenData = null)
        {
            _oAuthToken = tokenData;
            _checkToken = true;
            _funcGetTokenData = funcGetTokenData;

            _youZanClient = new DefaultYZClient();
        }

        /// <summary>
        /// 初始化API工具类
        /// </summary>
        /// <param name="clientId">客户端Id</param>
        /// <param name="clientSecret">客户端秘钥</param>
        /// <param name="grantId">店铺id</param>
        public ApiHelper(string clientId, string clientSecret, string grantId = null)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            GrantId = grantId;

            _youZanClient = new DefaultYZClient();

            RefreshAccessToken();
        }

        private void RefreshAccessToken(bool refresh = false)
        {
            var silent = new Silent(ClientId, ClientSecret, GrantId);
            if (refresh)
            {
                _oAuthToken = YouZanConfig.SaveAccessTokenToDB ? silent.GetNewTokenData(false) : silent.GetToken(true);
            }
            else
                _oAuthToken = silent.GetToken();
        }

        /// <summary>
        /// 生成请求参数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        private IDictionary<string, object> GenericParameter<T>(T t) where T : YouZanRequest
        {
            IDictionary<string, object> dict = new ConcurrentDictionary<string, object>();
            var type = t.GetType();
            foreach (var item in type.GetProperties())
            {
                if (item.PropertyType == typeof(YouZanRequest))
                {
                    var tmp = item.GetValue(type) as YouZanRequest;
                    dict.Add(item.GetApiField(), GenericParameter(tmp));
                }
                else
                {
                    dict.Add(item.GetApiField(), item.GetValue(t));
                }
            }
            return dict;
        }

        private T GetResponse<T>(GeneralApi api, IAuth auth, IDictionary<string, string> headers, List<KeyValuePair<string, string>> files)
            where T : YouZanResponse
        {
            var result = _youZanClient.Invoke(api, auth, headers, files);
            return JsonConvert.DeserializeObject<T>(result);
        }

        private T Invoke<T>(YouZanRequest request,
            string apiName,
            string apiVersion,
            string method = ApiConst.HTTP_POST,
            IDictionary<string, string> headers = null,
            List<KeyValuePair<string, string>> files = null) where T : YouZanResponse
        {
            var generalApi = new GeneralApi
            {
                Version = apiVersion,
                HttpMethod = method,
                ServiceName = apiName,
                ClientId = ClientId,
                GrantId = GrantId,
                OAuthType = OAuthEnum.TOKEN
            };
            // generalApi.SetName(apiName);
            // generalApi.SetVersion(apiVersion);
            // generalApi.SetClientId(ClientId);
            // generalApi.SetGrantId(GrantId);
            // generalApi.SetHttpMethod(method);
            // generalApi.SetOAuthType(OAuthEnum.TOKEN);

            var apiParams = new GeneralApiParams();
            apiParams.AddParam(GenericParameter(request));

            // generalApi.SetAPIParams(apiParams);
            generalApi.ApiParams = apiParams;

            var resp = GetResponse<T>(generalApi, new Token(_oAuthToken.Token), headers, files);

            // 当Token失效或Token不存在时，强制刷新AccessToken并且重新请求
            var errCodes = new[] { 4201, 4202, 4203 };
            if (resp.ErrorResponse == null || !errCodes.Contains(resp.ErrorResponse.ErrorCode)) return resp;
            if (_checkToken)
            {
                if (_funcGetTokenData == null)
                    return resp;
                _oAuthToken = _funcGetTokenData();
            }
            else
            {
                RefreshAccessToken(true);
            }
            resp = GetResponse<T>(generalApi, new Token(_oAuthToken.Token), headers, files);

            return resp;
        }

        /// <summary>
        /// 执行API请求
        /// </summary>
        /// <param name="request">请求参数值</param>
        /// <param name="apiName">api名称</param>
        /// <param name="apiVersion">api版本</param>
        /// <param name="method">api版本</param>
        /// <param name="headers">http请求头信息</param>
        /// <param name="files">文件列表（暂不支持）</param>
        /// <returns></returns>
        private YouZanResponse ApiInvoke(YouZanRequest request,
            string apiName,
            string apiVersion,
            string method = ApiConst.HTTP_POST,
            IDictionary<string, string> headers = null,
            List<KeyValuePair<string, string>> files = null)
        {
            return Invoke<YouZanResponse>(request, apiName, apiVersion, method, headers, files);
        }

        /// <summary>
        /// 执行API请求
        /// </summary>
        /// <typeparam name="T">响应参数</typeparam>
        /// <param name="request">请求参数值</param>
        /// <param name="apiName">api名称</param>
        /// <param name="apiVersion">api版本</param>
        /// <param name="method">api版本</param>
        /// <param name="headers">http请求头信息</param>
        /// <param name="files">文件列表（暂不支持）</param>
        /// <returns></returns>
        private YouZanResponse<T> ApiInvoke<T>(YouZanRequest request,
            string apiName,
            string apiVersion,
            string method = ApiConst.HTTP_POST,
            IDictionary<string, string> headers = null,
            List<KeyValuePair<string, string>> files = null)
        {
            return Invoke<YouZanResponse<T>>(request, apiName, apiVersion, method, headers, files);
        }
    }
}
