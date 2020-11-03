using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Ump
{
    public class UmpCouponConsumeGetRequest :YouZanRequest
    {
        /// <summary>
        /// 买家端优惠券/码核销码，即买家在店铺个人中心看到的优惠券/码对应的核销码值
        /// </summary>
        [ApiField("code")]
        public string Code { get; set; }
    }
}
