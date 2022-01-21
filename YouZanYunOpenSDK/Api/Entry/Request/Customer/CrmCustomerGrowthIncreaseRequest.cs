using System.Collections.Generic;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    public class CrmCustomerGrowthIncreaseRequest : YouZanRequest
    {
        [ApiField("params")]
        public GrowthParams Params { get; set; }
    }

    public class GrowthParams
    {
        /// <summary>
        /// 积分变动原因
        /// </summary>
        [ApiField("reason")]
        public string reason { get; set; }

        /// <summary>
        /// 业务唯一标示
        /// </summary>
        [ApiField("biz_value")]
        public string biz_value { get; set; }

        /// <summary>
        /// 积分变动值
        /// </summary>
        [ApiField("points")]
        public int amount { get; set; }

        [ApiField("user")]
        public User user { get; set; }

        /// <summary>
        /// 是否发送微信通知
        /// </summary>
        [ApiField("need_send_message")]
        public bool NeedSendMessage { get; set; }
        
    }
}