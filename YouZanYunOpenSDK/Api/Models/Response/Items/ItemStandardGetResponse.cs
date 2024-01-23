using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Items
{
    public class ItemStandardGetResponse
    {
        /// <summary>
        /// 产品信息
        /// </summary>
        [JsonProperty("spu")]
        public List<SPU> SPU { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("extra_info")]
        public List<ExtraInfo> ExtraInfoList { get; set; }

        /// <summary>
        /// 商品图片,json数组,包含图片width,图片url,图片id
        /// [{"width":1000,"id":"20148","url":"http://img.yzcdn.cn/upload_files/2017/07/11/FnbdmWX7iSr42gj7J3DqFbtpB9lE.jpg","height":1000}]
        /// </summary>
        [JsonProperty("extra_info")]
        public string Imgs { get; set; }

        /// <summary>
        /// 商品价格，单位：分
        /// </summary>
        [JsonProperty("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 商品类型,0-普通商品,5-外卖商品,10-分销商品,20-会员卡商品,22-团购券,24-周期购,31-知识付费商品,32-医药商品(已废弃),35-酒店商品,40-美业商品
        /// </summary>
        [JsonProperty("item_type")]
        public int ItemType { get; set; }

    }
    
    /// <summary>
    /// 产品信息
    /// </summary>
    public class SPU
    {

        /// <summary>
        /// 有效期
        /// 24个月
        /// </summary>
        [JsonProperty("valid_period")]
        public string ValidPeriod { get; set; }

        /// <summary>
        /// 商标品牌
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 厂商
        /// 修正药业有限公司
        /// </summary>
        [JsonProperty("manu_name")]
        public string ManuName { get; set; }
    }

    /// <summary>
    /// 扩展信息
    /// </summary>
    public class ExtraInfo
    {
        /// <summary>
        /// 扩展信息id
        /// </summary>
        [JsonProperty("kid")]
        public long KID { get; set; }

        /// <summary>
        /// 扩展信息key,如:一级类目、二级类目、标签、通用名称、商品编码
        /// </summary>
        [JsonProperty("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 扩展信息值
        /// </summary>
        [JsonProperty("attr_value")]
        public string AttrValue { get; set; }
    }
}
