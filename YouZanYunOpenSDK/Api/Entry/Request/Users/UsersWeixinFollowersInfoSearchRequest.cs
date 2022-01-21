using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    /// <summary>
    /// 根据关注时间段批量查询微信粉丝用户信息参数实体
    /// </summary>
    public class UsersWeixinFollowersInfoSearchRequest : YouZanRequest
    {
        /// <summary>
        /// 关注的起始时间。查询在该时间之后（包含该时间）关注的粉丝，不能为空。格式可为“20170101”或“2017-01-01 12:00:00"
        /// </summary>
        /// <example>2017-01-01 12:00:00</example>
        [ApiField("start_follow")]
        public string StartFollow { get; set; }
        /// <summary>
        /// 关注的结束时间。查询在该时间之前关注的粉丝，不能为空，查询时间间隔不能超过一天，格式同start_follow
        /// </summary>
        /// <example>2017-01-02 12:00:00</example>
        [ApiField("end_follow")]
        public string EndFollow { get; set; }
        /// <summary>
        /// 是否仅拉取关注的粉丝。1:仅拉取已关注的粉丝 0:拉取已关注和已跑路粉丝0:拉取已关注和已跑路粉丝，1:仅拉取已关注的粉丝
        /// </summary>
        /// <example>1</example>
        [ApiField("only_follow")]
        public short OnlyFollow { get; set; }
        /// <summary>
        /// 页码，page_no * page_size参数不超过10000。若备选数据多于10000条，请通过调整start_follow/end_follow来缩小时间范围。
        /// </summary>
        /// <example>1</example>
        [ApiField("page_no")]
        public int PageNo { get; set; }
        /// <summary>
        /// 每页条数，最大值：50。默认为10。
        /// </summary>
        /// <example>10</example>
        [ApiField("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 需要返回的除微信粉丝基础信息外的资产信息。枚举值：points，trade，level。points可获取“points”字段，trade可获取”traded_num,trade_money”两个字段，level可获取”level_info”字段信息。传多个枚举值需用“,”分隔，如果该字段为空则只返回粉丝基础信息。默认为空。(“fields”字段传入枚举值越多，查询数据耗费时间越长。）
        /// </summary>
        /// <example>points</example>
        [ApiField("fields")]
        public string Fields { get; set; }
    }
}
