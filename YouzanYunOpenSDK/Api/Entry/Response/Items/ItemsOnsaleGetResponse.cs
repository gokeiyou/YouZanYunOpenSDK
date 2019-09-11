using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Items
{
    public class ItemsOnsaleGetResponse
    {

        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonProperty("items")]
        public List<Commodity> CommodityList { get; set; }

        /// <summary>
        /// 搜索到的商品数量
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

    }

    public class Commodity
    {

        /// <summary>
        /// 创建时间
        /// 格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 总库存
        /// </summary>
        [JsonProperty("quantity")]
        public long quantity { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        [JsonProperty("item_imgs")]
        public List<CommodityImage> Images { get; set; }

        /// <summary>
        /// 运费模版
        /// </summary>
        [JsonProperty("delivery_template")]
        public DeliveryTemplate DeliveryTemplate { get; set; }

        /// <summary>
        /// 商品编码，商家可以自定义参数，支持英文和数据组合
        /// </summary>
        [JsonProperty("item_no")]
        public string item_no { get; set; }

        /// <summary>
        /// 商品价格
        /// 单位：分
        /// </summary>
        [JsonProperty("price")]
        public long price { get; set; }

        /// <summary>
        /// 最后更新时间
        /// 格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 默认值"youzan_goods_selling"
        /// </summary>
        [JsonProperty("classid")]
        public string ClassId { get; set; }

        /// <summary>
        /// 运费类型
        /// 1—统一运费
        /// 2—运费模板
        /// </summary>
        [JsonProperty("post_type")]
        public int PostType { get; set; }

        /// <summary>
        /// 商品图片链接
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// 划线价
        /// 单位：元
        /// </summary>
        [JsonProperty("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        [JsonProperty("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 商品别名，可通过接口youzan.items.onsale.get或youzan.items.inventory.get获取
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 商品小程序访问地址
        /// </summary>
        [JsonProperty("page_url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 运费，单位：分
        /// </summary>
        [JsonProperty("post_fee")]
        public long PostFee { get; set; }

        /// <summary>
        /// 商品Id，微商城店铺下商品唯一标识
        /// </summary>
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 商品价格，与price值一致，单位：分
        /// </summary>
        [JsonProperty("share_detail")]
        public long ShareDetail { get; set; }

        /// <summary>
        /// 商品类型：
        /// 0—普通商品
        /// 3—UMP降价拍
        /// 5—外卖商品
        /// 10—分销商品
        /// 20—会员卡商品
        /// 21—礼品卡商品
        /// 22—团购券
        /// 25—批发商品
        /// 30—收银台商品
        /// 31—知识付费商品
        /// 35—酒店商品
        /// 40—美业商品
        /// 60—虚拟商品
        /// 61—电子卡券
        /// </summary>
        [JsonProperty("item_type")]
        public int ItemType { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("share_title")]
        public string ShareTitle { get; set; }

        /// <summary>
        /// 商品图片链接，与image字段内容一致
        /// </summary>
        [JsonProperty("share_icon")]
        public string ShareIcon { get; set; }

        /// <summary>
        /// 商品详情链接
        /// </summary>
        [JsonProperty("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 商家排序字段
        /// </summary>
        [JsonProperty("num")]
        public long Num { get; set; }

    }

    public class CommodityImage
    {

        /// <summary>
        /// 图片缩略图链接地址
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        /// 组合图片链接地址
        /// </summary>
        [JsonProperty("combine")]
        public string Combine { get; set; }

        /// <summary>
        /// 图片创建时间 格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("created")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 图片链接地址
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 图片Id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 中号大小图片链接地址
        /// </summary>
        [JsonProperty("medium")]
        public string Medium { get; set; }

    }

    public class DeliveryTemplate
    {

        /// <summary>
        /// 运费范围，单位：元
        /// </summary>
        [JsonProperty("delivery_template_fee")]
        public string DeliveryTemplateFee { get; set; }

        /// <summary>
        /// 运费模板名称
        /// </summary>
        [JsonProperty("delivery_template_name")]
        public string DeliveryTemplateName { get; set; }

        /// <summary>
        /// 运费计费类型
        /// 1—按件计费
        /// 2—按重量计费
        /// 3—体积计费
        /// </summary>
        [JsonProperty("delivery_template_valuation_type")]
        public int DeliveryTemplateValuationType { get; set; }

        /// <summary>
        /// 运费模板Id，可调用youzan.logistics.template.search接口获取运费模版详情
        /// </summary>
        [JsonProperty("delivery_template_id")]
        public long DeliveryTemplateId { get; set; }

    }

}
