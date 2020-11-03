using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Ump
{
    public class UmpPromocardBuyerSearchRequest :YouZanRequest
    {

        /// <summary>
        /// 用户手机号
        /// </summary>
        [ApiField("mobile")]
        public long Mobile { get; set; }


        /// <summary>
        /// 三方App用户ID，该参数仅限购买App开店插件的商家使用
        /// </summary>
        [ApiField("open_user_id")]
        public long OpenUserId { get; set; }


        [ApiField("fans_type")]
        public long FansType { get; set; }

        [ApiField("status")]
        public string Status { get; set; }

        [ApiField("fans_id")]
        public long FansId { get; set; }

    }
}
