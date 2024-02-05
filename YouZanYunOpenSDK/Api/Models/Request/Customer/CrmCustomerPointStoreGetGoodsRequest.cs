using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Models.Request.Customer
{
    public class CrmCustomerPointStoreGetGoodsRequest : YouZanRequest
    {
        /// <summary>
        /// 商品id / 优惠券码id / 权益卡id，根据 goods_type 的含义不同，所代表的 id 类型不同。
        /// </summary>
        [ApiField("goods_id")]
        public long? GoodsId { get; set; }

        /// <summary>
        /// 商品类型（1.普通商品 2.优惠券/码 3.权益卡）
        /// </summary>
        [ApiField("goods_type")]
        public int? GoodsType { get; set; }

        /// <summary>
        /// 积分商品id（推荐使用，传参pointsGoodsId的话就不需要传goodsId goodsType）
        /// </summary>
        [ApiField("points_goods_id")]
        public long? PointsGoodsId { get; set; }
    }
}