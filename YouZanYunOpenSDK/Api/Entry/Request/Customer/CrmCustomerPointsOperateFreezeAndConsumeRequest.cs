using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 冻结&消费用户积分 请求参数实体
    /// </summary>
    public class CrmCustomerPointsOperateFreezeAndConsumeRequest : YouZanRequest
    {
        /// <summary>
        /// 参数明细
        /// </summary>
        [ApiField("params")]
        public CrmCustomerPointsOperateFreezeAndConsumeParams Params { get; set; }
    }

    /// <summary>
    /// 参数
    /// </summary>
    public class CrmCustomerPointsOperateFreezeAndConsumeParams
    {
        /// <summary>
        /// 用户
        /// </summary>
        [ApiField("user")]
        public CrmCustomerPointsOperateFreezeAndConsumeUser User { get; set; }
        /// <summary>
        /// 业务唯一标示，如订单号
        /// </summary>
        [ApiField("biz_value")]
        public string BizValue { get; set; }
        /// <summary>
        /// 冻结&消费积分值
        /// </summary>
        [ApiField("points")]
        public int Points { get; set; }
        /// <summary>
        /// 是否需要走扩展点，默认：true(false走内部逻辑)
        /// </summary>
        [ApiField("is_do_ext_point")]
        public bool IsDoExtPoint { get; set; }
        /// <summary>
        /// 业务二级唯一标示，如时间戳,bizvalue+biztoken共同决定唯一一次操作
        /// </summary>
        [ApiField("biz_token")]
        public string BizToken { get; set; }
        /// <summary>
        /// 消费类型:100：积分商城，101：退款，102：积分抵现，103：营销逆向退积分，201：外部系统
        /// </summary>
        [ApiField("consume_type")]
        public int ConsumeType { get; set; }
    }

    /// <summary>
    /// 用户类
    /// </summary>
    public class CrmCustomerPointsOperateFreezeAndConsumeUser
    {
        /// <summary>
        /// 操作人名字，可选字段
        /// </summary>
        [ApiField("operator_name")]
        public string OperatorName { get; set; }
        /// <summary>
        /// 帐号类型;支持的用户账号类型
        /// 1-有赞粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id) ;
        /// 2-手机号;
        /// 3-三方帐号(原open_user_id:三方App用户ID，该参数仅限购买App开店插件的商家使用) ;
        /// 5-有赞用户id，用户在有赞的唯一id。推荐使用）
        /// </summary>
        [ApiField("account_type")]
        public int AccountType { get; set; }
    }
}