using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 获取用户积分兑换记录 请求参数
    /// </summary>
    public class CrmCustomerPointStoreExchangeRecordsRequest : YouZanRequest
    {
        /// <summary>
        /// 分页大小（最多每页50条）
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// 开始时间（秒级时间戳）
        /// </summary>
        [JsonProperty("begin_time")]
        public long BeginTime { get; set; }

        /// <summary>
        /// 结束时间（秒级时间戳）
        /// </summary>
        [JsonProperty("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 兑换类型 1.普通商品 2.优惠券 3.权益卡
        /// </summary>
        [JsonProperty("goods_type")]
        public int GoodsType { get; set; }
    }
}