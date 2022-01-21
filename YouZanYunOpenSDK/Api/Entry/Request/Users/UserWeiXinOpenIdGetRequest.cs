using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    /// <summary>
    /// 使用手机号或有赞openId获取用户的微信openId
    /// </summary>
    /// <see cref="https://doc.youzanyun.com/detail/API/0/12"/>
    public class UserWeiXinOpenIdGetRequest : YouZanRequest
    {

        /// <summary>
        /// 手机号国际码，当前仅支持国内手机号
        /// </summary>
        [ApiField("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [ApiField("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 类型
        /// 1、表示公众号
        /// 2、表示小程序
        /// </summary>
        [ApiField("wechat_type")]
        public int WechatType { get; set; }

        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id。推荐使用
        /// </summary>
        /// <example>LnhGm4rh576452722916618240</example>
        [ApiField("yz_open_id")]
        public int YzOpenId { get; set; }

    }
}
