using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 获取用户积分兑换记录 返回参数
    /// </summary>
    public class CrmCustomerPointStoreExchangeRecordsResponse
    {
        /// <summary>
        /// 商品标题
        /// </summary>
        [JsonProperty("goods_title")]
        public string GoodsTitle { get; set; }

        /// <summary>
        /// 流水号id
        /// </summary>
        [JsonProperty("statement_no")]
        public string StatementNo { get; set; }

        /// <summary>
        /// 兑换的金额（100=1元，1=0.01元）
        /// </summary>
        [JsonProperty("cost_price")]
        public long CostPrice { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("goods_count")]
        public int GoodsCount { get; set; }

        /// <summary>
        /// 兑换时间（秒级时间戳）
        /// </summary>
        [JsonProperty("created_time")]
        public long CreatedTime { get; set; }

        /// <summary>
        /// 抵扣的金额
        /// </summary>
        [JsonProperty("reduced_price")]
        public int ReducedPrice { get; set; }

        /// <summary>
        /// 优惠券类型 0优惠券 1优惠码
        /// </summary>
        [JsonProperty("coupon_group_type")]
        public int CouponGroupType { get; set; }

        /// <summary>
        /// 商品类型 1.普通商品 2.优惠券 3.权益卡
        /// </summary>
        [JsonProperty("goods_type")]
        public int GoodsType { get; set; }

        /// <summary>
        /// 商品id 当兑换的商品为优惠券/优惠码时 goods_id 就是优惠券/优惠码的id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 商品图片地址
        /// </summary>
        [JsonProperty("goods_img")]
        public string GoodsImage { get; set; }

        /// <summary>
        /// 消耗积分数
        /// </summary>
        [JsonProperty("cost_points")]
        public int CostPoints { get; set; }
    }
}