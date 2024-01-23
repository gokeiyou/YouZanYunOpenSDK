using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 查询权益卡下对应的会员列表参数
    /// </summary>
    public class ScrmCustomerSearchRequest : YouZanRequest
    {
        /// <summary>
        /// 商家权益卡的唯一标识
        /// </summary>
        [ApiField("card_alias")]
        public string CardAlias { get; set; }
        /// <summary>
        /// 每页默认30条，最大支持500页
        /// </summary>
        [ApiField("page")]
        public int Page { get; set; }
    }
}
