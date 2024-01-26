using System.Collections.Generic;
using Newtonsoft.Json;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 积分商城兑换商品查询接口 响应参数
    /// </summary>
    public class CrmCustomerPointStoreListGoodsResponse
    {
        /// <summary>
        /// 积分商品详细信息
        /// </summary>
        [JsonProperty("point_exchange_response_d_t_o")]
        public List<PointExchangeResponse> PointExchangeList { get; set; }

        /// <summary>
        /// 返回数据总量
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    /// <summary>
    /// 积分商品详细信息
    /// </summary>
    public class PointExchangeResponse
    {
        /// <summary>
        /// 权益卡信息
        /// </summary>
        [JsonProperty("benefit_card_info_d_t_o")]
        public BenefitCardInfo BenefitCardInfo { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("general_goods_info_d_t_o")]
        public GeneralGoodsInfoDTO GeneralGoodsInfoDto { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("point_goods_exchange_threshold_d_t_o")]
        public PointGoodsExchangeThresholdDTO PointGoodsExchangeThresholdDto { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("point_goods_sku_info_d_t_o_list")]
        public List<PointGoodsSkuInfoDTO> PointGoodsSkuInfoDTOList { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("coupon_group_info_d_t_o")]
        public CouponGroupInfoDTO CouponGroupInfoDto { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("term_start_at")]
        public long TermStartAt { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("goods_channel")]
        public int GoodsChannel { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("point_goods_stock_d_t_o")]
        public PointGoodsStockDTO PointGoodsStockDto { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("point_goods_exchange_price_d_t_o")]
        public PointGoodsExchangePriceDTO PointGoodsExchangePriceDto { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("term_end_at")]
        public long TermEndAt { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("point_goods_id")]
        public long PointGoodsId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("goods_type")]
        public int GoodsType { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("state")]
        public int State { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("trade_point_goods_id")]
        public long TradePointGoodsId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("allow_purchase_at_original_price")]
        public bool AllowPurchaseAtOriginalPrice { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [ApiField("has_sku")]
        public bool HasSku { get; set; }
    }

    /// <summary>
    /// 权益卡信息
    /// </summary>
    public class BenefitCardInfo
    {
        /// <summary>
        /// 卡模板id
        /// </summary>
        [JsonProperty("card_tpl_id")]
        public long CardTplId { get; set; }

        /// <summary>
        /// 卡别名
        /// </summary>
        [JsonProperty("card_alias")]
        public string CardAlias { get; set; }

        /// <summary>
        /// 卡名
        /// </summary>
        [JsonProperty("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 卡描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 卡售价，单位：分，整数。
        /// </summary>
        [JsonProperty("selling_price")]
        public int SellingPrice { get; set; }

        /// <summary>
        /// 封面图片
        /// </summary>
        [JsonProperty("background_img")]
        public string BackgroundImg { get; set; }

        /// <summary>
        /// 卡背景色
        /// </summary>
        [JsonProperty("background_color_code")]
        public string BackgroundColorCode { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonProperty("stock")]
        public int Stock { get; set; }

        /// <summary>
        /// 详情链接
        /// </summary>
        [JsonProperty("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 有效期描述
        /// </summary>
        [JsonProperty("term_desc")]
        public string TermDesc { get; set; }
    }

    /// <summary>
    /// 普通商品信息
    /// </summary>
    public class GeneralGoodsInfoDTO
    {
        /// <summary>
        /// 普通商品id
        /// </summary>
        [JsonProperty("general_goods_id")]
        public long GeneralGoodsId { get; set; }

        /// <summary>
        /// 分销商品供货价，单位：元,精确到小数点后2位
        /// </summary>
        [JsonProperty("supplier_price")]
        public long SupplierPrice { get; set; }

        /// <summary>
        /// 普通商品标题
        /// </summary>
        [JsonProperty("general_goods_title")]
        public string GeneralGoodsTitle { get; set; }

        /// <summary>
        /// 已参加的互斥营销活动
        /// </summary>
        [JsonProperty("joined_other_mutex_activity")]
        public List<string> JoinedOtherMutexActivity { get; set; }

        /// <summary>
        /// 详情链接
        /// </summary>
        [JsonProperty("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonProperty("stock")]
        public long Stock { get; set; }

        /// <summary>
        /// 普通商品别名
        /// </summary>
        [JsonProperty("general_goods_alias")]
        public string GeneralGoodsAlias { get; set; }

        /// <summary>
        /// 普通商品价格，单位：分，整数
        /// </summary>
        [JsonProperty("general_goods_price")]
        public long GeneralGoodsPrice { get; set; }

        /// <summary>
        /// 商品渠道(0:网店,1:门店)
        /// </summary>
        [JsonProperty("general_goods_channel")]
        public int GeneralGoodsChannel { get; set; }

        /// <summary>
        /// 普通商品图片
        /// </summary>
        [JsonProperty("general_goods_img")]
        public string GeneralGoodsImg { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [JsonProperty("general_goods_type")]
        public int GeneralGoodsType { get; set; }
    }

    /// <summary>
    /// 兑换门槛
    /// </summary>
    public class PointGoodsExchangeThresholdDTO
    {
        /// <summary>
        /// 限制拥有某张卡的用户可兑
        /// </summary>
        [JsonProperty("available_card_ids")]
        public List<long> AvailableCardIds { get; set; }

        /// <summary>
        /// 单人限兑数量
        /// </summary>
        [JsonProperty("exchange_count_by_single_user")]
        public int ExchangeCountBySingleUser { get; set; }

        /// <summary>
        /// 限制满足这些等级的用户可兑
        /// </summary>
        [JsonProperty("available_level_ids")]
        public List<long> AvailableLevelIds { get; set; }
    }

    /// <summary>
    /// 积分商品普通商品规格信息,ump侧无多规格的情况下会存储ic的综合skuid
    /// </summary>
    public class PointGoodsSkuInfoDTO
    {
        /// <summary>
        /// 积分兑换
        /// </summary>
        [JsonProperty("point_goods_exchange_price_d_t_o")]
        public PointGoodsExchangePriceDTO PointGoodsExchangePriceDTO { get; set; }

        /// <summary>
        /// 兑换限制
        /// </summary>
        [JsonProperty("point_goods_exchange_threshold_d_t_o")]
        public PointGoodsExchangeThresholdDTO PointGoodsExchangeThresholdDTO { get; set; }

        /// <summary>
        /// 普通商品skuId
        /// </summary>
        [JsonProperty("general_goods_sku_id")]
        public long GeneralGoodsSkuId { get; set; }

        /// <summary>
        /// 是否生效；true-生效，false-未生效
        /// </summary>
        [JsonProperty("is_activated")]
        public bool IsActivated { get; set; }

        /// <summary>
        /// 库存信息
        /// </summary>
        [JsonProperty("point_goods_stock_d_t_o")]
        public PointGoodsStockDTO PointGoodsStockDTO { get; set; }
    }

    /// <summary>
    /// 优惠券码信息
    /// </summary>
    public class CouponGroupInfoDTO
    {
        /// <summary>
        /// 券码名
        /// </summary>
        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 优惠面额（单位：分，精确到小数点后0位）
        /// </summary>
        [JsonProperty("denominations")]
        public long Denominations { get; set; }

        /// <summary>
        /// 使用门槛；0-无门槛，n-门槛值（单位：分，精确到小数点后0位）
        /// </summary>
        [JsonProperty("condition")]
        public long Condition { get; set; }

        /// <summary>
        /// 背景图
        /// </summary>
        [JsonProperty("background_img")]
        public string BackgroundImg { get; set; }

        /// <summary>
        /// 券码类型（0:券,1:码）
        /// </summary>
        [JsonProperty("group_type")]
        public int GroupType { get; set; }

        /// <summary>
        /// 优惠属性；1-代金券 2-折扣券
        /// </summary>
        [JsonProperty("preferential_type")]
        public short PreferentialType { get; set; }

        /// <summary>
        /// 优惠券码的加密alias，优惠券码小程序拼链接用
        /// </summary>
        [JsonProperty("id_alias")]
        public string IdAlias { get; set; }

        /// <summary>
        /// 详情链接
        /// </summary>
        [JsonProperty("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 折扣（例：88，8.8折）
        /// </summary>
        [JsonProperty("discount")]
        public int Discount { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonProperty("stock")]
        public int Stock { get; set; }

        /// <summary>
        /// 优惠描述
        /// </summary>
        [JsonProperty("preferential_desc")]
        public string PreferentialDesc { get; set; }

        /// <summary>
        /// 有效期描述
        /// </summary>
        [JsonProperty("term_desc")]
        public string TermDesc { get; set; }

        /// <summary>
        /// 卡券id
        /// </summary>
        [JsonProperty("coupon_group_id")]
        public long CouponGroupId { get; set; }

        /// <summary>
        /// 使用说明
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    /// <summary>
    /// 兑换库存
    /// </summary>
    public class PointGoodsStockDTO
    {
        /// <summary>
        /// 剩余库存
        /// </summary>
        [JsonProperty("available_stock")]
        public int AvailableStock { get; set; }

        /// <summary>
        /// 总库存
        /// </summary>
        [JsonProperty("total_stock")]
        public int TotalStock { get; set; }

        /// <summary>
        /// 已兑换数
        /// </summary>
        [JsonProperty("exchanged_count")]
        public int ExchangedCount { get; set; }
    }

    /// <summary>
    /// 兑换价格
    /// </summary>
    public class PointGoodsExchangePriceDTO
    {
        /// <summary>
        /// 积分值
        /// </summary>
        [JsonProperty("points")]
        public int Points { get; set; }

        /// <summary>
        /// 现金值，单位：分，整数
        /// </summary>
        [JsonProperty("cash")]
        public int Cash { get; set; }

        /// <summary>
        /// 是否使用统一兑换比例；true-是，false-否
        /// </summary>
        [JsonProperty("use_general_ratio")]
        public bool UseGeneralRatio { get; set; }
    }
}