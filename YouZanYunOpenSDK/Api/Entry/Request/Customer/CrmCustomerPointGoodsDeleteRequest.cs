using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 删除积分商城的积分商品信息 请求参数实体
    /// </summary>
    public class CrmCustomerPointGoodsDeleteRequest : YouZanRequest
    {
        /// <summary>
        /// 商品类型：1-普通商品，2-优惠券，3-会员卡
        /// </summary>
        /// <example>1</example>
        [JsonProperty("goods_type")]
        public int GoodsType { get; set; }
        /// <summary>
        /// 商品Id，有赞生成的店铺下商品唯一id，平台唯一。可以通过列表接口如youzan.items.onsale.get （查询出售中商品）和 youzan.items.inventory.get （查询仓库中商品）获取
        /// </summary>
        /// <example>385534708</example>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }
        /// <summary>
        /// 积分商品Id，有赞生成的店铺下积分商品唯一id，平台唯一。可以通过列表接口如youzan.crm.customer.pointstore.find.pointgoods （查询积分商品）和 youzan.crm.customer.pointstore.create.pointgoods （创建积分商品中返回的pointGoodsId）获取
        /// </summary>
        /// <example>13093</example>
        [JsonProperty("point_goods_id")]
        public long PointGoodsId { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>
        [JsonProperty("operator")]
        public Operator Operator { get; set; }
    }

    /// <summary>
    /// 操作员
    /// </summary>
    public class Operator
    {
        /// <summary>
        /// 账号类型（1-有赞粉丝，2-手机号，3-三方账号，4-union_id账号，5-open_id账号）
        /// </summary>
        /// <example>2</example>
        [JsonProperty("account_type")]
        public int AccountType { get; set; }
        /// <summary>
        /// 帐号ID
        /// </summary>
        /// <example>13726876523</example>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        /// <summary>
        /// 操作人名字
        /// </summary>
        /// <example>张三</example>
        [JsonProperty("operator_name")]
        public string OperatorName { get; set; }
    }
}
