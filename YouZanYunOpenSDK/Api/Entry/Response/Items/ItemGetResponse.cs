using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Items
{
    public class ItemGetResponse :YouZanResponse<ItemGetResponse>
    {
        [JsonProperty("item")]
        public Item Item { get; set; }
    }

    public class Item
    {
        [JsonProperty("item_cate_prop_open_model")]
        public ItemCatePropOpenModel ItemCatePropOpenModel { get; set; }

        /// <summary>
        /// 运费，单位：分
        /// </summary>
        [JsonProperty("post_fee")]
        public long PostFee { get; set; }

        /// <summary>
        /// SKUS
        /// </summary>
        [JsonProperty("skus")]
        public List<Skus> Skus { get; set; }

        /// <summary>
        /// 是否设置商品购买权限。true—已设置，false—未设置
        /// </summary>
        [JsonProperty("purchase_right")]
        public bool PurchaseRight { get; set; }


        public SkuImages SkuImages { get; set; }
        
        [JsonProperty("purchase_right_list")]

        public PurchaseRightList PurchaseRightList { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("delivery_template_info")]
        public DeliveryTemplateInfo DeliveryTemplateInfo { get; set; }

        [JsonProperty("item_imgs")]
        public List<ItemImgs>  ItemImgs { get; set; }

        /// <summary>
        /// 商品名即商品标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品主图片地址
        /// </summary>
        [JsonProperty("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        ///  总库存
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("virtual_extend")]

        public VirtualExtend VirtualExtend { get; set; }

        /// <summary>
        ///  商品卖点

        /// </summary>
        [JsonProperty("sell_point")]
        public string sell_point { get; set; }

        /// <summary>
        ///  商品创建时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("created")]
        public string Created { get; set; }


        /// <summary>
        /// 商品主图片缩略图地址
        /// </summary>
        [JsonProperty("pic_thumb_url")]
        public string PicThumbUrl { get; set; }


        /// <summary>
        /// 是否开启唯一码管理,只对零售门店商品有效,0:否; 1:是
        /// </summary>
        [JsonProperty("is_serial_item")]
        public string IsSerialItem { get; set; }


        /// <summary>
        /// 划线价 单位：元
        /// </summary>
        [JsonProperty("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 商品状态，true—已上架，false—已下架
        /// </summary>
        [JsonProperty("is_listing")]
        public bool IsListing { get; set; }


        /// <summary>
        /// 商品定时上架（定时开售）的时间，格式：格式"yyyy-MM-dd HH:mm:ss"，注：不是定时上架商品该参数不返回。
        /// </summary>
        [JsonProperty("auto_listing_time")]
        public string AutoListingTime { get; set; }

 
        [JsonProperty("template")]
        public Template Template { get; set; }


        /// <summary>
        /// 商品关联总部商品id
        /// </summary>
        [JsonProperty("root_item_id")]
        public long RootItemId { get; set; }

        /// <summary>
        /// 商品类型： 0—普通商品 3—UMP降价拍 5—外卖商品 10—分销商品 20—会员卡商品 21—礼品卡商品 22—团购券 25—批发商品 30—收银台商品 31—知识付费商品 35—酒店商品 40—美业商品 60—虚拟商品 61—电子卡券
        /// </summary>
        [JsonProperty("item_type")]
        public int ItemType { get; set; }

        [JsonProperty("tag_ids")]
        public List<long> TagIds { get; set; }

        [JsonProperty("kdt_id")]
        public long KdtId { get; set; }


        [JsonProperty("spu")]
        public Spu Spu { get; set; }

        /// <summary>
        /// 是否参加会员折扣，true—支持，false—不支持
        /// </summary>
        [JsonProperty("join_level_discount")]
        public bool JoinLevelDiscount { get; set; }

        /// <summary>
        /// 商品Id，微商城店铺下商品唯一标识
        /// </summary>
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        [JsonProperty("detail_url")]
        public string DetailUrl { get; set; }


        [JsonProperty("messages")]
        public string Messages { get; set; }

        [JsonProperty("hotel_extend")]
        public HotelExtend HotelExtend { get; set; }

        [JsonProperty("one_item_multi_code")]
        public string OneItemMultiCode { get; set; }


        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("item_tags")]
        public List<ItemTag>  ItemTags { get; set; }

        [JsonProperty("cid")]
        public string Cid { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }


        [JsonProperty("presale_extend")]
        public PresaleExtend PresaleExtend { get; set; }

        [JsonProperty("item_no")]
        public string item_no { get; set; }

        [JsonProperty("item_channel_extra_open_model")]
        public ItemChannelExtraOpenModel ItemChannelExtraOpenModel { get; set; }

        [JsonProperty("cost_price")]
        public long CostPrice { get; set; }



        [JsonProperty("root_kdt_id")]
        public long RootKdtId { get; set; }

        [JsonProperty("num")]
        public long Num { get; set; }

        [JsonProperty("sold_num")]
        public long SoldNum { get; set; }

        [JsonProperty("fenxiao_extend")]
        public FenxiaoExtend FenxiaoExtend { get; set; }
        [JsonProperty("post_type")]
        public int PostType { get; set; }

        [JsonProperty("is_lock")]
        public bool IsLock { get; set; }


        [JsonProperty("buy_quota")]
        public long BuyQuota { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

    }

    public class ItemTag
    {
    }

    public class PresaleExtend
    {
    }

    public class FenxiaoExtend
    {
    }

    public class ItemChannelExtraOpenModel
    {
    }

    public class HotelExtend
    {
    }

    public class Spu
    {
    }

    public class Template
    {
    }

    public class VirtualExtend
    {
    }

    public class ItemImgs
    {
    }

    public class DeliveryTemplateInfo
    {
    }

    public class PurchaseRightList
    {
    }

    public class SkuImages
    {
        /// <summary>
        /// 规格项Id，第一级规格项
        /// </summary>
        [JsonProperty("k_id")]
        public long KeyId { get; set; }

        /// <summary>
        ///  规格Id
        /// </summary>
        [JsonProperty("v_id")]
        public long ValId { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [JsonProperty("img_url")]
        public string ImgUrl { get; set; }

        
    }

    public class Skus
    {
        /// <summary>
        /// 唯一编码，商品Id和规格Id组合。可用于判断商品唯一性
        /// </summary>
        [JsonProperty("sku_unique_code")]
        public string SkuUniqueCode { get; set; }
        /// <summary>
        /// 规格重量 单位克
        /// </summary>
        [JsonProperty("sku_weight")]
        public long SkuWeight { get; set; }

        /// <summary>
        /// 商品编码，兼容历史字段
        /// </summary>
        [JsonProperty("outer_id")]
        public string OuterId { get; set; }
        /// <summary>
        /// 规格Id，微商城店铺商品规格标识（同一商品Id下，规格id唯一）
        /// </summary>
        [JsonProperty("sku_id")]
        public long SkuId { get; set; }
        /// <summary>
        /// SKU级别一品多码
        /// </summary>
        [JsonProperty("one_item_multi_code")]
        public string OneItemMultiCode { get; set; }
        /// <summary>
        /// SKU销量
        /// </summary>
        [JsonProperty("sold_num")]
        public long SoldNum { get; set; }
        /// <summary>
        /// 规格编码，商家可以自定义参数，支持 英文和数字组合
        /// </summary>
        [JsonProperty("item_no")]
        public string ItemNo { get; set; }
        /// <summary>
        /// SKU最后修改日期，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("modified")]
        public string Modified { get; set; }
        /// <summary>
        /// 该规格商品是否可以销售。仅商品类型为分销商品时返回。
        /// </summary>
        [JsonProperty("is_sell")]
        public int IsSell { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cost_price")]
        public long CostPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_sku_id")]
        public long RootSkuId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("properties_name_json")]
        public string PropertiesNameJson { get; set; }

        /// <summary>
        /// SKU创建日期，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("created")]
        public string Created { get; set; }

        /// <summary>
        /// 商品在付款减库存的状态下，该Sku上未付款的订单数量
        /// </summary>
        [JsonProperty("with_hold_quantity")]
        public long WithHoldQuantity { get; set; }

        /// <summary>
        /// SKU商品数量
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品SKU的价格，单位:：分
        /// </summary>
        [JsonProperty("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品Id，微商城店铺下商品唯一标识
        /// </summary>
        [JsonProperty("item_id")]
        public long ItemId { get; set; }
        

    }

    public class ItemCatePropOpenModel
    {
        /// <summary>
        /// 新类目ID叶子类目
        /// </summary>
        [JsonProperty("leaf_category_id")]
        public string LeafCategoryId { get; set; }

        /// <summary>
        /// 类目状态 1：正常 2：禁用
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 类目全路径 按照 层级顺序 1、2、3 或者 叶子类目名称
        /// ["家用电器","个人护理","体重秤/健康秤"]
        /// </summary>
        [JsonProperty("category_names")]
        public List<string> CategoryNames { get; set; }

        [JsonProperty("item_properties_open_model")]
        public ItemPropertiesOpenModel ItemPropertiesOpenModel { get; set; }

    }

    public class ItemPropertiesOpenModel
    {
        [JsonProperty("publics")]
        public List<Public>  Publics { get; set; }
    }

    public class Public
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("pro_name")]
        public string ProName { get; set; }

        /// <summary>
        /// 属性值有多选情况，如：["红色"]
        /// </summary>
        [JsonProperty("val_names")]
        public List<string> ValNames { get; set; }

    }
}