using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 删除用户的权益卡请求实体
    /// </summary>
    public class ScrmCustomerCardDeleteRequest : YouZanRequest
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [ApiField("params")]
        public ScrmCustomerCardDeleteParams Params { get; set; }
    }

    public class ScrmCustomerCardDeleteParams : YouZanRequest
    {
        /// <summary>
        /// 三方应用id
        /// </summary>
        [ApiField("client_id")]
        public string ClientId { get; set; }
        /// <summary>
        /// 卡号（卡号和卡别名必填一个）
        /// </summary>
        [ApiField("card_no")]
        public string CardNo { get; set; }
        /// <summary>
        /// 卡别名（卡号和卡别名必填一个）
        /// </summary>
        [ApiField("card_alias")]
        public string CardAlias { get; set; }
        /// <summary>
        /// 客户信息
        /// </summary>
        [ApiField("user")]
        public ParamUser User { get; set; }
    }
}
