using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Items
{
    /// <summary>
    /// 根据编码和商品类型查询API请求实体
    /// </summary>
    public class ItemStandardGetRequest: YouZanRequest
    {
        /// <summary>
        /// 商品条码
        /// </summary>
        [ApiField("code")]
        public string Code { get; set; }

        /// <summary>
        /// 商品类型,0-普通商品,5-外卖商品,10-分销商品,20-会员卡商品,22-团购券,24-周期购,31-知识付费商品,32-医药商品(已废弃),35-酒店商品,40-美业商品
        /// </summary>
        [ApiField("item_type")]
        public int? ItemType { get; set; }
    }
}
