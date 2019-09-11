using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Api.Constant;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Request.Salesman;
using YouZan.Open.Api.Entry.Request.Scrm;
using YouZan.Open.Api.Entry.Request.Users;
using YouZan.Open.Api.Entry.Response;
using YouZan.Open.Api.Entry.Response.Salesman;
using YouZan.Open.Api.Entry.Response.Scrm;
using YouZan.Open.Auth;
using YouZan.Open.Common.Constant;
using YouZan.Open.Core;
using YouZan.Open.TokenEx;
using static YouZan.Open.TokenEx.OauthToken;

namespace YouZan.Open.Api
{
    public class ApiHelper
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
        private ulong GrantId { get; set; }

        IYouZanClient yzClient = null;
        TokenData oAuthToken = null;

        /// <summary>
        /// 初始化API工具类
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public ApiHelper(string clientId, string clientSecret)
            : this(clientId, clientSecret, 0)
        {
            
        }

        public ApiHelper(string clientId, string clientSecret, ulong grantId)
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.GrantId = grantId;

            yzClient = new DefaultYZClient();

            Silent silent = new Silent(this.ClientId, this.ClientSecret, this.GrantId);
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
            IDictionary<string, object> dict = new Dictionary<string, object>();
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
                    dict.Add(item.GetApiField(), item.GetValue(type));
                }
            }
            return dict;
        }

        /// <summary>
        /// 执行API请求
        /// </summary>
        /// <typeparam name="TIn">请求参数</typeparam>
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
            string method,
            IDictionary<string, string> headers = null,
            List<KeyValuePair<string, string>> files = null)
        {
            GeneralApi generalApi = new GeneralApi();
            generalApi.SetName(apiName);
            generalApi.SetVersion(apiVersion);
            generalApi.SetHttpMethod(method);
            generalApi.SetOAuthType(OAuthEnum.TOKEN);

            GeneralApiParams apiParams = new GeneralApiParams();
            apiParams.AddParam(this.GenericParameter(request));

            generalApi.SetAPIParams(apiParams);

            string result = yzClient.Invoke(generalApi, new Token(oAuthToken.Token), headers, files);

            return JsonConvert.DeserializeObject<YouZanResponse<T>>(result);
        }

        #region 用户API请求

        /// <summary>
        /// 查询是否存在有赞帐号
        /// 传入参数参考{"account_type":"Mobile", "account_id":"1385716120"}
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<bool> UsersAccountCheck(UsersAccountCheckRequest request)
        {
            return ApiInvoke<bool>(
                request,
                API.USERS_ACCOUNT_CHECK,
                API.VERSION_1_0_0,
                API.METHOD_GET);
        }

        #endregion

        #region 客户API请求

        /// <summary>
        /// 创建客户
        /// 手机号和{"name":"丽丽"}必填
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<ScrmCustomerCreateResponse> ScrmCustomerCreate(ScrmCustomerCreateRequest request)
        {
            return ApiInvoke<ScrmCustomerCreateResponse>(
                request,
                API.SCRM_CUSTOMER_CREATE,
                API.VERSION_3_0_0,
                API.METHOD_POST
                );
        }

        #endregion

        #region 分销员API请求

        /// <summary>
        /// 设置用户为分销员
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<SalesmanAccountAddResponse> SalesmanAccountAdd(SalesmanAccountAddRequest request)
        {
            return ApiInvoke<SalesmanAccountAddResponse>(
                request,
                API.SALESMAN_ACCOUNT_ADD,
                API.VERSION_3_0_1,
                API.METHOD_POST);
        }

        /// <summary>
        /// 更新分销员信息,客户已经是分销员才可以更新
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<SalesmanAccountUpdateResponse> SalesmanAccountUpdate(SalesmanAccountUpdateRequest request)
        {
            return ApiInvoke<SalesmanAccountUpdateResponse>(
                request,
                API.SALESMAN_ACCOUNT_UPDATE,
                API.VERSION_3_0_0,
                API.METHOD_POST);
        }

        #endregion

    }
}
