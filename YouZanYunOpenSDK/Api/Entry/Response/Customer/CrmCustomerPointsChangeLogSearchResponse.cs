using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 查询用户积分日志 返回实体
    /// </summary>
    public class CrmCustomerPointsChangeLogSearchResponse
    {
        /// <summary>
        /// 返回页数和条数
        /// </summary>
        [JsonProperty("paginator")]
        public ChangeLogSearchPaginator paginator { get; set; }
        /// <summary>
        /// 积分日志集合
        /// </summary>
        [JsonProperty("items")]
        public List<PointsChangeLogItem> Items { get; set; }
    }

    /// <summary>
    /// 返回页数和条数
    /// </summary>
    public class ChangeLogSearchPaginator
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }
        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    /// <summary>
    /// 积分日志
    /// </summary>
    public class PointsChangeLogItem
    {
        /// <summary>
        /// 创建时间（秒级时间戳）
        /// </summary>
        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }
        /// <summary>
        /// 过期时间（秒级时间戳）
        /// </summary>
        [JsonProperty("expired_at")]
        public long ExpiredAt { get; set; }
        /// <summary>
        /// 操作之后的最新积分数值
        /// </summary>
        [JsonProperty("current")]
        public long Current { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// 积分值（负数为扣积分）
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }
        /// <summary>
        /// 三方调用加/减积分接口传入的biz_value, 三方未传入则不会返回
        /// </summary>
        [JsonProperty("biz_value")]
        public string BizValue { get; set; }
    }
}
