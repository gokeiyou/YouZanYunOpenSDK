using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 给客户减成长值请求参数
    /// </summary>
    public class CrmCustomerGrowthDecreaseRequest : YouZanRequest
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [ApiField("params")]
        public CrmCustomerGrowthDecreaseParams Params { get; set; }
    }

    /// <summary>
    /// 请求参数
    /// </summary>
    public class CrmCustomerGrowthDecreaseParams : YouZanRequest
    {
        /// <summary>
        /// 变动原因
        /// </summary>
        [ApiField("reason")]
        public string Reason { get; set; }
        /// <summary>
        /// 成长值变动值
        /// </summary>
        [ApiField("amount")]
        public int Amount { get; set; }
        /// <summary>
        /// 请确保业务唯一标识唯一性，相同唯一标识，接口只会进行一次扣减。
        /// </summary>
        [ApiField("biz_value")]
        public string BizValue { get; set; }
        /// <summary>
        /// 是否需要走扩展点，默认：true（外部开发者无需关注该字段）
        /// </summary>
        [ApiField("is_do_ext_point")]
        public bool IsDoExtPoint { get; set; }
        /// <summary>
        /// 是否发送微信通知
        /// </summary>
        [ApiField("need_send_message")]
        public bool NeedSendMessage { get; set; }
        /// <summary>
        /// 客户账号信息
        /// </summary>
        [ApiField("user")]
        public ParamUser User { get; set; }
    }
}
