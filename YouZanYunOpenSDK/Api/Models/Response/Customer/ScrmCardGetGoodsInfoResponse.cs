using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 查询付费权益卡商品id 返回参数
    /// </summary>
    public class ScrmCardGetGoodsInfoResponse
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("items_id")]
        public long ItemsId { get; set; }
    }
}