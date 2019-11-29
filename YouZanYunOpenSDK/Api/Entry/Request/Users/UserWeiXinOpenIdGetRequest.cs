using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
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

    }
}
