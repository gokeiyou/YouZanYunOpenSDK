using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Api.Constant;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Response;
using YouZan.Open.Api.Entry.Response.Users;

namespace YouZan.Open.Api
{
    /// <summary>
    /// 用户模块API
    /// </summary>
    /// <see cref="https://doc.youzanyun.com/list/API/1286"/>
    public partial class ApiHelper
    {
        /// <summary>
        /// 获取有赞openId，根据userId（有赞账号id）查询有赞openId(注意是有赞openId，非微信openId)
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、零售单店、美业总部、教育多校区-总部、有赞连锁D-总部、有赞连锁D-网店、有赞连锁D-合伙人、零售连锁前置仓、有赞连锁L-总部、有赞连锁L-总部-高级版、有赞连锁L-网店、有赞连锁L-网店-Lite、有赞连锁L-门店、有赞连锁L-合伙人、有赞连锁L-供货商、有赞连锁L-独立仓库、教育单校区、教育多校区-分部、酒店、企微助手
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/323"/>
        /// <returns></returns>
        public YouZanResponse<UserOpenApiGetResponse> UserOpenApiGet(YouZanRequest request)
        {
            return ApiInvoke<UserOpenApiGetResponse>(
                request,
                ApiConst.USER_OPENAPI_GET,
                ApiConst.VERSION_1_0_0);
        }

        /// <summary>
        /// 用户查询接口,用户信息查询接口。 查询条件说明： 1. 支持根据yz_open_id查询 2. 支持根据mobile（国内手机号）查询 3. 支持根据unionId（微信体系下帐号标识）查询 4. 支持weixin_open_id + open_id_type查询，支持微信公众号H5，微信小程序、有赞大账号 5. 查询优先级yz_open_id>mobile>weixin_union_id>weixin_open_id 返回结果说明： 1. 默认只返回用户对应的手机帐号信息（platform_type = 0） 2. 可使用result_type_list控制返回结果，如传入[1, 9]则返回自有粉丝和大账号粉丝； 补充说明：在微信公众号场景下，正常会进行两次授权，一次通过商家公众号授权，一次通过有赞公众号授权，分别产生不同的用户数据： 1）1-微信公众号：通过商家的公众号授权产生的用户 2）9-微信大账号：通过”有赞“公众号授权产生的用户
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、有赞连锁D-总部、有赞连锁D-网店、有赞连锁D-合伙人、零售单店、美业总部、教育多校区-总部、零售连锁前置仓、有赞连锁L-总部、有赞连锁L-总部-高级版、有赞连锁L-网店、有赞连锁L-网店-Lite、有赞连锁L-门店、有赞连锁L-合伙人、有赞连锁L-供货商、有赞连锁L-独立仓库、教育单校区、教育多校区-分部、酒店、企微助手
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/2193"/>
        /// <returns></returns>
        public YouZanResponse<UsersInfoQueryResponse> UsersInfoQuery(YouZanRequest request)
        {
            return ApiInvoke<UsersInfoQueryResponse>(
                request,
                ApiConst.USERS_INFO_QUERY,
                ApiConst.VERSION_1_0_0);
        }

        /// <summary>
        /// 根据关注时间段批量查询微信粉丝用户信息,根据fansId正序批量查询微信粉丝用户信息（不受关注时间限制），仅支持商家自己公众号下的粉丝查新
        /// </summary>
        /// <remarks>
        /// 已支持：零售单店、教育多校区-总部、微商城单店、有赞连锁D-总部、有赞连锁D-网店、有赞连锁D-合伙人、美业总部、零售连锁前置仓、有赞连锁L-总部、有赞连锁L-总部-高级版、有赞连锁L-网店、有赞连锁L-网店-Lite、有赞连锁L-门店、有赞连锁L-合伙人、有赞连锁L-供货商、有赞连锁L-独立仓库、教育单校区、教育多校区-分部、酒店、企微助手
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/132"/>
        /// <returns></returns>
        public YouZanResponse<UsersWeixinFollowersInfoSearchResponse> UsersWeiXinFollowersInfoSearch(YouZanRequest request)
        {
            return ApiInvoke<UsersWeixinFollowersInfoSearchResponse>(
                request,
                ApiConst.USERS_WEIXIN_FOLLOWS_INFO_SEARCH,
                ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// 获取单个粉丝标签集合，调用时，参数 weixin_openid 和 fans_id 选其一即可,只支持商家自有粉丝（fanstype为1的）
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、零售单店、教育多校区-总部
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/105"/>
        /// <returns></returns>
        public YouZanResponse<UsersWeixinFollowerTagsGetResponse> UsersWeiXinFollowerTagsGet(YouZanRequest request)
        {
            return ApiInvoke<UsersWeixinFollowerTagsGetResponse>(
                request,
                ApiConst.USERS_WEIXIN_FOLLOWER_TAGS_GET,
                ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// App开店用户解绑(App开店专属接口)
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3833"/>
        /// <returns></returns>
        public YouZanResponse UsersAppShopUnbind(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse>(
                request,
                ApiConst.USERS_APPSHOP_UNBIND,
                ApiConst.VERSION_1_0_0);
        }

        /// <summary>
        /// [新增] 仅限购买APP开店插件商家使用，查询app开店的用户信息。
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3606"/>
        /// <returns></returns>
        public YouZanResponse<UserAppShopGetInfoResponse> UserAppShopGetInfo(YouZanRequest request)
        {
            return ApiInvoke<UserAppShopGetInfoResponse>(
                request,
                ApiConst.USER_APP_SHOP_GET_INFO,
                ApiConst.VERSION_1_0_0);
        }

        /// <summary>
        /// 获取单个粉丝标签集合，调用时，参数 weixin_openid 和 fans_id 选其一即可,只支持商家自有粉丝（fanstype为1的）
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、零售单店、教育多校区-总部
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/910"/>
        /// <returns></returns>
        public YouZanResponse<UsersChannelCodeUltraGetResponse> UsersChannelCodeUltraGet(YouZanRequest request)
        {
            return ApiInvoke<UsersChannelCodeUltraGetResponse>(
                request,
                ApiConst.USERS_CHANNEL_CODE_ULTRA_GET,
                ApiConst.VERSION_1_0_0);
        }

        /// <summary>
        /// 获取客户列表
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、零售单店、有赞连锁D-总部、有赞连锁D-网店、有赞连锁D-合伙人、有赞连锁L-总部、有赞连锁L-总部-高级版、有赞连锁L-网店、有赞连锁L-网店-Lite、有赞连锁L-门店、有赞连锁L-合伙人、有赞连锁L-供货商、有赞连锁L-独立仓库
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/755"/>
        /// <returns></returns>
        public YouZanResponse<UserCustomerSearchResponse> UserCustomerSearch(YouZanRequest request)
        {
            return ApiInvoke<UserCustomerSearchResponse>(
                request,
                ApiConst.USERS_SCRM_CUSTOMER_SEARCH,
                ApiConst.VERSION_3_1_2);
        }

        /// <summary>
        /// 删除三方帐号信息，用于App开店帐号一键授权
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、零售单店、有赞连锁D-总部、有赞连锁D-网店、有赞连锁D-合伙人、教育多校区-总部
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3946"/>
        /// <returns></returns>
        public YouZanResponse<bool> UserWechatDelete(YouZanRequest request)
        {
            return ApiInvoke<bool>(
                request,
                ApiConst.USERS_WECHAT_DELETE,
                ApiConst.VERSION_1_0_0);
        }

        /// <summary>
        /// 获取单个粉丝标签集合，调用时，参数 weixin_openid 和 fans_id 选其一即可,只支持商家自有粉丝（fanstype为1的）
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、零售单店、教育多校区-总部
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/103"/>
        /// <returns></returns>
        public YouZanResponse<UsersWeixinFollowerTagsAddResponse> UsersWeiXinFollowerTagsAdd(YouZanRequest request)
        {
            return ApiInvoke<UsersWeixinFollowerTagsAddResponse>(
                request,
                ApiConst.USERS_WEIXIN_FOLLOWER_TAGS_ADD,
                ApiConst.VERSION_3_0_0);
        }
        
        /// <summary>
        /// 查询是否存在有赞帐号
        /// 传入参数参考{"account_type":"Mobile", "account_id":"1385716120"}
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/21"/>
        /// <returns></returns>
        public YouZanResponse<bool> UsersAccountCheck(YouZanRequest request)
        {
            return ApiInvoke<bool>(
                request,
                ApiConst.USERS_ACCOUNT_CHECK,
                ApiConst.VERSION_1_0_0);
        }

        /// <summary>
        /// 根据微信粉丝用户的 weixin_openid 或 fans_id 删除对应的标签，一次删除的标签数量不能大于20。只支持商家自有粉丝（fanstype为1的）
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、零售单店、教育多校区-总部
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/133"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse> UsersWeiXinFollowerTagsDelete(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse>(
                request,
                ApiConst.USERS_WEIXIN_FOLLOWER_TAGS_DELETE,
                ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// 使用手机号获取用户微信openId
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/12"/>
        /// <returns></returns>
        public YouZanResponse<UserWeiXinOpenIdGetResponse> UserWeiXinOpenIdGet(YouZanRequest request)
        {
            return ApiInvoke<UserWeiXinOpenIdGetResponse>(
                request,
                ApiConst.USER_WEIXIN_OPENID_GET,
                ApiConst.VERSION_3_0_0);
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
                ApiConst.USER_BASIC_GET,
                ApiConst.VERSION_3_0_1);
        }
    }
}
