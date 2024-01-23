using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    public class CrmCustomerPointsDecreaseRequest : YouZanRequest
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [ApiField("params")]
        public CrmCustomerPointsDecreaseParam Params { get; set; }
    }

    /// <summary>
    /// 给用户减积分参数明细
    /// </summary>
    public class CrmCustomerPointsDecreaseParam
    {
        /// <summary>
        /// 积分变动原因
        /// </summary>
        [ApiField("reason")]
        public string Reason { get; set; }
        /// <summary>
        /// 渠道来源，主要指产生积分的交易渠道
        /// </summary>
        [ApiField("channel_type")]
        public int? ChannelType { get; set; }
        /// <summary>
        /// 请确保业务唯一标识唯一性，相同唯一标识，接口只会进行一次扣减。
        /// </summary>
        [ApiField("biz_value")]
        public string BizValue { get; set; }
        /// <summary>
        /// 是否检验客户信息 默认false
        /// </summary>
        [ApiField("check_customer")]
        public bool? CheckCustomer { get; set; }
        /// <summary>
        /// 积分变动值
        /// </summary>
        [ApiField("points")]
        public int Points { get; set; }
        /// <summary>
        /// 是否需要走扩展点，默认：true(false走内部逻辑)
        /// </summary>
        [ApiField("is_do_ext_point")]
        public bool? IsDoExtPoint { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        [ApiField("user")]
        public ParamUser User { get; set; }
    }
}