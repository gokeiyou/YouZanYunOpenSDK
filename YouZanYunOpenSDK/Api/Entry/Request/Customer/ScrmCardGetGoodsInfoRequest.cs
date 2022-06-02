using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 查询付费权益卡商品id 请求参数
    /// </summary>
    public class ScrmCardGetGoodsInfoRequest : YouZanRequest
    {
        /// <summary>
        /// 卡模版id
        /// </summary>
        [ApiField("card_tp_id")]
        public long CardTemplateId { get; set; }
        /// <summary>
        /// 卡模版别名
        /// </summary>
        [ApiField("card_tp_alias")]
        public string CardTemplateAlias { get; set; }
    }
}