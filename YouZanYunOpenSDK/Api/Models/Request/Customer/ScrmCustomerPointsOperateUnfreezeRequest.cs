using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 解冻用户积分 请求参数
    /// </summary>
    public class ScrmCustomerPointsOperateUnfreezeRequest
    {
        /// <summary>
        /// 用户
        /// </summary>
        [ApiField("user")]
        public ParamUser User { get; set; }
        /// <summary>
        /// 积分变动原因
        /// </summary>
        [ApiField("reason")]
        public string reason { get; set; }
        /// <summary>
        /// 冻结时的业务唯一标示，如订单号
        /// </summary>
        [ApiField("biz_value")]
        public string biz_value { get; set; }
        /// <summary>
        /// 二级唯一索引，如传入，则与bizValue共同唯一决定一次积分操作
        /// </summary>
        [ApiField("biz_token")]
        public string biz_token { get; set; }
        /// <summary>
        /// 消费类型: 100：积分商城，101：退款，102：积分抵现，103：营销逆向退积分，201：外部系统
        /// </summary>
        [ApiField("consume_type")]
        public int consume_type { get; set; }
    }
}