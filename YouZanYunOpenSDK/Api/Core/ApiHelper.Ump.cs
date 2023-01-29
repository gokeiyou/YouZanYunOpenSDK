using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Api.Constant;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Response;
using YouZan.Open.Api.Entry.Response.Ump;

namespace YouZan.Open.Api
{
    /// <summary>
    /// 营销模块API
    /// </summary>
    /// <see cref="https://doc.youzanyun.com/list/API/1294"/>
    public partial class ApiHelper
    {
        /// <summary>
        /// （分页查询）查询优惠券/码活动列表
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/159"/>
        /// <returns></returns>
        public YouZanResponse<UmpCouponSearchResponse> UmpCouponSearch(YouZanRequest request)
        {
            return ApiInvoke<UmpCouponSearchResponse>(request,
               ApiConst.UMP_COUPON_SEARCH,
               ApiConst.VERSION_3_0_0);
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
        /// <see cref="https://doc.youzanyun.com/detail/API/0/155"/>
        /// <returns></returns>
        public YouZanResponse<UmpCouponTakeResponse> UmpCouponTake(YouZanRequest request)
        {
            return ApiInvoke<UmpCouponTakeResponse>(request,
               ApiConst.UMP_COUPON_TAKE,
               ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// 根据核销码获取优惠券/优惠码
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/142"/>
        /// <returns></returns>
        public YouZanResponse<UmpCouponConsumeGetResponse> UmpCouponConsumeGet(YouZanRequest request)
        {
            return ApiInvoke<UmpCouponConsumeGetResponse>(request,
                ApiConst.UMP_COUPON_CONSUME_GET,
                ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// 查询买家优惠券列表
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/163"/>
        /// <returns></returns>
        public YouZanResponse<List<UmpPromocardBuyerSearchResponse>> UmpPromocardBuyerSearch(YouZanRequest request)
        {
            return ApiInvoke<List<UmpPromocardBuyerSearchResponse>>(request,
                ApiConst.UMP_PROMOCRAD_BUYER_SEARCH,
                ApiConst.VERSION_3_0_2);
        }
    }
}
