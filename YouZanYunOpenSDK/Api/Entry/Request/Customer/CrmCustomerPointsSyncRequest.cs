using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 同步客户积分请求参数
    /// </summary>
    public class CrmCustomerPointsSyncRequest : YouZanRequest
    {
        /// <summary>
        /// 积分变动值
        /// </summary>
        [ApiField("points")]
        public int Points { get; set; }
        /// <summary>
        /// 用户信息
        /// </summary>
        [ApiField("user")]
        public ParamUser User { get; set; }
        /// <summary>
        /// 积分变动原因
        /// </summary>
        [ApiField("reason")]
        public string Reason { get; set; }
        /// <summary>
        /// 是否需要走扩展点，默认：true（涉及到的扩展点：，，）
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/EXT/40"/>
        [ApiField("is_do_extpoint")]
        public bool? IsDoExtPoint { get; set; }
        /// <summary>
        /// 外部业务标识；用于幂等支持（幂等时效三个月, 超过三个月的相同值调用不保证幂等）[即相同帐号、业务标识字段的重复调用在三个月内不会重复发放积分]
        /// </summary>
        [ApiField("biz_value")]
        public string BizValue { get; set; }
    }
}