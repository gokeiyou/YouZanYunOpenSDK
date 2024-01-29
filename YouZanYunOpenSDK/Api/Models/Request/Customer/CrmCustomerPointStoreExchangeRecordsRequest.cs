using YouZan.Open.Common.Extensions.Attributes;

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
        [ApiField("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        [ApiField("user")]
        public User User { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [ApiField("page")]
        public int Page { get; set; }

        /// <summary>
        /// 开始时间（秒级时间戳）
        /// </summary>
        [ApiField("begin_time")]
        public long BeginTime { get; set; }

        /// <summary>
        /// 结束时间（秒级时间戳）
        /// </summary>
        [ApiField("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 兑换类型 1.普通商品 2.优惠券 3.权益卡
        /// </summary>
        [ApiField("goods_type")]
        public int GoodsType { get; set; }
    }
}