using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 查询用户积分日志 请求参数实体
    /// </summary>
    public class CrmCustomerPointsChangeLogSearchRequest : YouZanRequest
    {
        /// <summary>
        /// 分页大小（最多每页50条）
        /// </summary>
        [ApiField("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 分页数
        /// </summary>
        [ApiField("page")]
        public int Page { get; set; }
        /// <summary>
        /// 起始时间（仅支持当前时间30天内的时间点。如果开始时间为空，则默认取当前时间开始最近7天内的记录）
        /// </summary>
        [ApiField("begin_time")]
        public string BeginTime { get; set; }
        /// <summary>
        /// 结束时间（以起始时间开始的7天内的时间点）
        /// </summary>
        [ApiField("end_time")]
        public string EndTime { get; set; }
        /// <summary>
        /// 是否需要走扩展点，默认：true （扩展点名称：查看用户积分变动日志）
        /// </summary>
        [ApiField("is_do_ext_point")]
        public bool IsDoExtPoint { get; set; }
    }

    /// <summary>
    /// 用户
    /// </summary>
    public class ChangeLogSearchUser
    {
        /// <summary>
        /// 帐号类型（支持的用户账号类型 1-有赞粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id) ; 2-手机号; 3-三方帐号(原open_user_id:三方App用户ID，该参数仅限购买App开店插件的商家使用) ;5-yzOpenId，用户在有赞的唯一id。推荐使用）
        /// </summary>
        /// <example>2</example>
        [ApiField("account_type")]
        public int AccountType { get; set; }
        /// <summary>
        /// 帐号ID
        /// </summary>
        /// <example>18972515558</example>
        [ApiField("account_id")]
        public string AccountId { get; set; }
    }
}
