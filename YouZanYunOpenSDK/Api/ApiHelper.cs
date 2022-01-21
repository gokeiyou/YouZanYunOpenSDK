using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
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
        private string ClientId { get; set; }

        /// <summary>
        /// 客户端密码
        /// </summary>
        private string ClientSecret { get; set; }
        /// <summary>
        /// 店铺ID
        /// </summary>
        private string GrantId { get; set; }

        IYouZanClient _YouZanClient = null;
        public TokenData oAuthToken = null;

        private bool _checkToken = false;
        private Func<TokenData> _funcGetTokenData;

        /// <summary>
        /// 初始化，直接传入TokenData
        /// </summary>
        /// <param name="tokenData">token</param>
        /// <param name="funcGetTokenData">获取新TokenData的委托</param>
        public ApiHelper(TokenData tokenData, Func<TokenData> funcGetTokenData = null)
        {
            oAuthToken = tokenData;
            _checkToken = true;
            _funcGetTokenData = funcGetTokenData;

            _YouZanClient = new DefaultYZClient();
        }

        /// <summary>
        /// 初始化API工具类
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public ApiHelper(string clientId, string clientSecret)
            : this(clientId, clientSecret, null)
        {

        }

        public ApiHelper(string clientId, string clientSecret, string grantId)
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.GrantId = grantId;

            _YouZanClient = new DefaultYZClient();

            this.GetAccessToken();
        }

        private void GetAccessToken(bool refresh = false)
        {
            Silent silent = new Silent(this.ClientId, this.ClientSecret, this.GrantId);
            if (refresh)
            {
                if (YouZanConfig.SaveAccessTokenToDB)
                    oAuthToken = silent.GetNewTokenData(false);
                else
                    oAuthToken = silent.GetToken(refresh);
            }
            else
                oAuthToken = silent.GetToken();
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
            Type type = t.GetType();
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
        protected YouZanResponse<T> ApiInvoke<T>(YouZanRequest request,
            string apiName,
            string apiVersion,
            string method = API.HTTP_POST,
            IDictionary<string, string> headers = null,
            List<KeyValuePair<string, string>> files = null)
        {

            GeneralApi generalApi = new GeneralApi();
            generalApi.SetName(apiName);
            generalApi.SetVersion(apiVersion);
            generalApi.SetClientId(ClientId);
            generalApi.SetGrantId(GrantId);
            generalApi.SetHttpMethod(method);
            generalApi.SetOAuthType(OAuthEnum.TOKEN);

            GeneralApiParams apiParams = new GeneralApiParams();
            apiParams.AddParam(this.GenericParameter(request));

            generalApi.SetAPIParams(apiParams);

            Func<YouZanResponse<T>> func = () =>
            {
                string result = _YouZanClient.Invoke(generalApi, new Token(oAuthToken.Token), headers, files);
                return JsonConvert.DeserializeObject<YouZanResponse<T>>(result);
            };

            var resp = func();

            // 当Token失效或Token不存在时，强制刷新AccessToken并且重新请求
            var errCodes = new[] { 4201, 4202, 4203 };
            if (resp.ErrorResponse != null && errCodes.Contains(resp.ErrorResponse.ErrorCode))
            {
                if (_checkToken)
                {
                    if (_funcGetTokenData == null)
                        return resp;
                    oAuthToken = _funcGetTokenData();
                }
                else
                {
                    this.GetAccessToken(true);
                }
                resp = func();
            }

            return resp;
        }
    }

    #region 交易API请求
    
    #endregion

}
