using System.Collections.Generic;
using Newtonsoft.Json;
using YouZan.Open.Api.Entry.Response;
using YouZan.Open.Api.Entry.Response.Customer;

namespace YouZan.Open.Api.Models.Response.Customer
{
    public class CrmCustomerPointStoreGetGoodsResponse : YouZanResponse 
    {
        /// <summary>
        /// 兑换库存
        /// </summary>
        [JsonProperty("point_goods_stock")]
        public PointGoodsStockDTO PointGoodsStock { get; set; }

        /// <summary>
        /// 兑换价格
        /// </summary>
        [JsonProperty("point_goods_exchange_price")]
        public PointGoodsExchangePriceDTO PointGoodsExchangePrice { get; set; }

        /// <summary>
        /// 活动开始时间戳（秒级）
        /// </summary>
        [JsonProperty("term_start_at")]
        public long TermStartAt { get; set; }

        /// <summary>
        /// 积分商品状态（1.未开始 2.进行中 3.已结束 4.已失效）
        /// </summary>
        [JsonProperty("state")]
        public int State { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 积分商品sku信息列表
        /// </summary>
        [JsonProperty("point_goods_sku_info_list")]
        public List<PointGoodsSkuInfoModel> PointGoodsSkuInfoList { get; set; }

        /// <summary>
        /// 活动结束时间戳（秒级）
        /// </summary>
        [JsonProperty("term_end_at")]
        public long TermEndAt { get; set; }

        /// <summary>
        /// 是否有多规格配置
        /// </summary>
        [JsonProperty("has_sku")]
        public bool HasSku { get; set; }

        /// <summary>
        /// 商品类型（1.普通商品 2.优惠券/码 3.权益卡）
        /// </summary>
        [JsonProperty("goods_type")]
        public int GoodsType { get; set; }
    }

    public class PointGoodsSkuInfoModel
    {
        /// <summary>
        /// sku配置
        /// </summary>
        [JsonProperty("point_goods_exchange_price")]
        public PointGoodsExchangePriceDTO PointGoodsExchangePrice { get; set; }

        /// <summary>
        /// sku库存
        /// </summary>
        [JsonProperty("point_goods_stock")]
        public PointGoodsStockDTO PointGoodsStock { get; set; }

        /// <summary>
        /// 普通商品skuId
        /// </summary>
        [JsonProperty("general_goods_sku_id")]
        public long GeneralGoodsSkuId { get; set; }

        /// <summary>
        /// 是否生效
        /// </summary>
        [JsonProperty("is_activated")]
        public bool IsActivated { get; set; }
    }
}