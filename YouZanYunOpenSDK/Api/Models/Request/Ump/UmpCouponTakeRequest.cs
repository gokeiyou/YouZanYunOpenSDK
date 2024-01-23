using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Ump
{
    public class UmpCouponTakeRequest : YouZanRequest
    {

        /// <summary>
        /// 用户手机号
        /// </summary>
        [ApiField("mobile")]
        public long Mobile { get; set; }

        /// <summary>
        /// 三方用户id（App开店）
        /// </summary>
        [ApiField("open_user_id")]
        public string OpenUserId { get; set; }

        /// <summary>
        /// 微信用户对应的openid
        /// </summary>
        [ApiField("weixin_openid")]
        public string WeiXinOpenId { get; set; }

        /// <summary>
        /// 优惠券/码活动ID
        /// </summary>
        [ApiField("coupon_group_id")]
        public long CouponGroupId { get; set; }

        /// <summary>
        /// 粉丝id，fans_id与weixin_openid存在一个即可
        /// </summary>
        [ApiField("fans_id")]
        public long FansId { get; set; }

    }
}
