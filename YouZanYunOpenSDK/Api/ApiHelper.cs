using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YouZan.Open.Api.Constant;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Request.Salesman;
using YouZan.Open.Api.Entry.Request.Scrm;
using YouZan.Open.Api.Entry.Request.Users;
using YouZan.Open.Api.Entry.Response;
using YouZan.Open.Api.Entry.Response.Crm;
using YouZan.Open.Api.Entry.Response.Items;
using YouZan.Open.Api.Entry.Response.Salesman;
using YouZan.Open.Api.Entry.Response.Scrm;
using YouZan.Open.Api.Entry.Response.Trade;
using YouZan.Open.Api.Entry.Response.Ump;
using YouZan.Open.Api.Entry.Response.Users;
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

            Func<YouZanResponse<T>> func = () => {
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

        #region 用户API请求

        /// <summary>
        /// 获取有赞openId，根据userId（有赞账号id）查询有赞openId(注意是有赞openId，非微信openId)
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、零售单店、美业总部、教育多校区-总部、有赞连锁D-总部、有赞连锁D-网店、有赞连锁D-合伙人、零售连锁前置仓、有赞连锁L-总部、有赞连锁L-总部-高级版、有赞连锁L-网店、有赞连锁L-网店-Lite、有赞连锁L-门店、有赞连锁L-合伙人、有赞连锁L-供货商、有赞连锁L-独立仓库、教育单校区、教育多校区-分部、酒店、企微助手
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<UserOpenApiGetResponse> UserOpenApiGet(YouZanRequest request)
        {
            return ApiInvoke<UserOpenApiGetResponse>(
                request,
                API.USER_OPENAPI_GET,
                API.VERSION_1_0_0);
        }

        /// <summary>
        /// 用户查询接口,用户信息查询接口。 查询条件说明： 1. 支持根据yz_open_id查询 2. 支持根据mobile（国内手机号）查询 3. 支持根据unionId（微信体系下帐号标识）查询 4. 支持weixin_open_id + open_id_type查询，支持微信公众号H5，微信小程序、有赞大账号 5. 查询优先级yz_open_id>mobile>weixin_union_id>weixin_open_id 返回结果说明： 1. 默认只返回用户对应的手机帐号信息（platform_type = 0） 2. 可使用result_type_list控制返回结果，如传入[1, 9]则返回自有粉丝和大账号粉丝； 补充说明：在微信公众号场景下，正常会进行两次授权，一次通过商家公众号授权，一次通过有赞公众号授权，分别产生不同的用户数据： 1）1-微信公众号：通过商家的公众号授权产生的用户 2）9-微信大账号：通过”有赞“公众号授权产生的用户
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、有赞连锁D-总部、有赞连锁D-网店、有赞连锁D-合伙人、零售单店、美业总部、教育多校区-总部、零售连锁前置仓、有赞连锁L-总部、有赞连锁L-总部-高级版、有赞连锁L-网店、有赞连锁L-网店-Lite、有赞连锁L-门店、有赞连锁L-合伙人、有赞连锁L-供货商、有赞连锁L-独立仓库、教育单校区、教育多校区-分部、酒店、企微助手
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<UsersInfoQueryResponse> UsersInfoQuery(YouZanRequest request)
        {
            return ApiInvoke<UsersInfoQueryResponse>(
                request,
                API.USERS_INFO_QUERY,
                API.VERSION_1_0_0);
        }


        /// <summary>
        /// 查询是否存在有赞帐号
        /// 传入参数参考{"account_type":"Mobile", "account_id":"1385716120"}
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<bool> UsersAccountCheck(YouZanRequest request)
        {
            return ApiInvoke<bool>(
                request,
                API.USERS_ACCOUNT_CHECK,
                API.VERSION_1_0_0);
        }

        /// <summary>
        /// 使用手机号获取用户微信openId
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<UserWeiXinOpenIdGetResponse> UserWeiXinOpenIdGet(YouZanRequest request)
        {
            return ApiInvoke<UserWeiXinOpenIdGetResponse>(
                request,
                API.USER_WEIXIN_OPENID_GET,
                API.VERSION_3_0_0);
        }

        /// <summary>
        /// 依据有赞openid 或者手机号 获取用户简要信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<UserBasicGetResponse> UserBasicGet(YouZanRequest request)
        {
            return ApiInvoke<UserBasicGetResponse>(
                request,
                API.USER_BASIC_GET,
                API.VERSION_3_0_1);
        }

        #endregion

        #region 客户API请求

        /// <summary>
        /// 创建客户
        /// 手机号和{"name":"丽丽"}必填
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<ScrmCustomerCreateResponse> ScrmCustomerCreate(YouZanRequest request)
        {
            return ApiInvoke<ScrmCustomerCreateResponse>(
                request,
                API.SCRM_CUSTOMER_CREATE,
                API.VERSION_3_0_0);
        }

        #endregion

        #region 分销员API请求

        /// <summary>
        /// 获取分销员账户信息，不支持返回分销员等级
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<SalesmanAccountGetResponse> SalesmanAccountGet(YouZanRequest request)
        {
            return ApiInvoke<SalesmanAccountGetResponse>(
                request,
                API.SALESMAN_ACCOUNT_GET,
                API.VERSION_3_0_0);
        }

        /// <summary>
        /// 设置用户为分销员
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<SalesmanAccountAddResponse> SalesmanAccountAdd(YouZanRequest request)
        {
            return ApiInvoke<SalesmanAccountAddResponse>(
                request,
                API.SALESMAN_ACCOUNT_ADD,
                API.VERSION_3_0_1);
        }

        /// <summary>
        /// 更新分销员信息,客户已经是分销员才可以更新
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<SalesmanAccountUpdateResponse> SalesmanAccountUpdate(YouZanRequest request)
        {
            return ApiInvoke<SalesmanAccountUpdateResponse>(
                request,
                API.SALESMAN_ACCOUNT_UPDATE,
                API.VERSION_3_0_0);
        }

        /// <summary>
        /// 清退分销员，客户必须是分销员才能清退
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<bool> SalesmanAccountFire(YouZanRequest request)
        {
            return ApiInvoke<bool>(request,
                API.SALESMAN_ACCOUNT_FIRE,
                API.VERSION_3_0_0);
        }

        /// <summary>
        /// 获取推广订单列表
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<SalesmanTradesGetResponse> SalesmanTradesGet(YouZanRequest request)
        {
            return ApiInvoke<SalesmanTradesGetResponse>(request,
                API.SALESMAN_TRADES_GET,
                API.VERSION_3_0_1);
        }

        /// <summary>
        /// 获取商品推广链接
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<SalesmanItemShareGetResponse> SalesmanItemShareGet(YouZanRequest request)
        {
            return ApiInvoke<SalesmanItemShareGetResponse>(request,
                API.SALESMAN_ITEM_SHARE_GET,
                API.VERSION_3_0_0);
        }

        /// <summary>
        /// 获取分销员业绩统计
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<SalesmanAccountScoreSearchResponse> SalesmanAccountScoreSearch(YouZanRequest request)
        {
            return ApiInvoke<SalesmanAccountScoreSearchResponse>(request,
                API.SALESMAN_ACCOUNT_SCORE_SEARCH,
                API.VERSION_3_0_0);
        }

        /// <summary>
        /// 批量获取商品提成比例信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<SalesmanItemsGetResponse> SalesmanItemsGet(YouZanRequest request)
        {
            return ApiInvoke<SalesmanItemsGetResponse>(request,
                API.SALESMAN_ITEMS_GET,
                API.VERSION_3_0_0);
        }

        #endregion

        #region 优惠券/码API请求

        public YouZanResponse<UmpCouponSearchResponse> UmpCouponSearch(YouZanRequest request)
        {
            return ApiInvoke<UmpCouponSearchResponse>(request,
               API.UMP_COUPON_SEARCH,
               API.VERSION_3_0_0);
        }

        /// <summary>
        /// 发放优惠券优惠码
        /// 用户身份标识（fans_id ，mobile，open_user_id，weixin_openid）设置一个即可。
        /// 用户身份标识说明： fans_id
        /// 仅支持微信服务号粉丝id mobile
        /// 发券用户手机号（手机号需注册有赞账号）
        /// open_user_id 三方App用户ID（仅App开店支持）
        /// weixin_openid 微信服务号粉丝用户的openid。
        /// 查询优先级：首先通过mobile查找，其次weixin_openid和fans_id，最后open_user_id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<UmpCouponTakeResponse> UmpCouponTake(YouZanRequest request)
        {
            return ApiInvoke<UmpCouponTakeResponse>(request,
               API.UMP_COUPON_TAKE,
               API.VERSION_3_0_0);
        }

        public YouZanResponse<UmpCouponConsumeGetResponse> UmpCouponConsumeGet(YouZanRequest request)
        {
            return ApiInvoke<UmpCouponConsumeGetResponse>(request,
                API.UMP_COUPON_CONSUME_GET,
                API.VERSION_3_0_0);
        }

        public YouZanResponse<List<UmpPromocardBuyerSearchResponse>> UmpPromocardBuyerSearch(YouZanRequest request)
        {
            return ApiInvoke<List<UmpPromocardBuyerSearchResponse>>(request,
                API.UMP_PROMOCRAD_BUYER_SEARCH,
                API.VERSION_3_0_0);
        }

        #endregion

        #region 商品API请求

        /// <summary>
        /// 获取出售中的商品列表，可获取微商城全部商品信息
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<ItemsOnsaleGetResponse> ItemsOnsaleGet(YouZanRequest request)
        {
            return ApiInvoke<ItemsOnsaleGetResponse>(request,
                API.ITEMS_ONSALE_GET,
                API.VERSION_3_0_0);
        }


        
        public YouZanResponse<ItemGetResponse> ItemGet(YouZanRequest request)
        {
            return ApiInvoke<ItemGetResponse>(request,
                API.ITEM_GET,
                API.VERSION_3_0_0);
        }

        /// <summary>
        /// 根据编码和商品类型查询查询商品标准
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<ItemStandardGetResponse> ItemStandardGet(YouZanRequest request)
        {
            return ApiInvoke<ItemStandardGetResponse>(request,
                API.ITEM_STANDARD_GET,
                API.VERSION_1_0_0);
        }

        #endregion

        #region 积分API请求

        public YouZanResponse<CrmCustomerPointsIncreaseResponse> CrmCustomerPointsIncrease(YouZanRequest request)
        {
            return ApiInvoke<CrmCustomerPointsIncreaseResponse>(request,
                API.CRM_CUSTOMER_POINTS_INCREASE,
                API.VERSION_4_0_0);
        }

        public YouZanResponse<CrmCustomerGrowthIncreaseResponse> CrmCustomerGrowthIncrease(YouZanRequest request)
        {
            return ApiInvoke<CrmCustomerGrowthIncreaseResponse>(request,
                API.CRM_CUSTOMER_GROWTH_INCREASE,
                API.VERSION_2_0_0);
        }
        #endregion

        #region 交易API请求

        /// <summary>
        /// 更新备注
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<TradeMemoUpdateResponse> TradeMemoUpdate(YouZanRequest request)
        {
            return ApiInvoke<TradeMemoUpdateResponse>(request,
                API.TRADE_MEMO_UPDATE,
                API.VERSION_3_0_0);
        }

        public YouZanResponse<TradeGetResponse> TradesGet(YouZanRequest request)
        {
            return ApiInvoke<TradeGetResponse>(request,
                API.TRADE_GET,
                API.VERSION_4_0_0);
        }

        public YouZanResponse<string> TradesGetString(YouZanRequest request)
        {
            return ApiInvoke<string>(request,
                API.TRADE_GET,
                API.VERSION_4_0_0);
        }

        #endregion

    }
}
