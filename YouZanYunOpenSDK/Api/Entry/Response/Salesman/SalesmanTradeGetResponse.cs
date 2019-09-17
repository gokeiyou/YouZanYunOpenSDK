using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Salesman
{
    public class SalesmanTradeGetResponse
    {
        /// <summary>
        /// 订单列表
        /// </summary>
        [JsonProperty("list")]
        public List<YouZanOrderInfo> OrderList { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }

    }

    public class YouZanOrderInfo
    {

        /// <summary>
        /// 订单明细列表
        /// </summary>
        [JsonProperty("items")]
        public List<YouZanOrderItem> OrderItems { get; set; }

        /// <summary>
        /// 是否自动结算，0是FALSE 1是TRUE
        /// </summary>
        [JsonProperty("auto_settle")]
        public int AutoSettle { get; set; }

        /// <summary>
        /// 结算时间
        /// </summary>
        [JsonProperty("settled_at")]
        public string SettledTime { get; set; }

        /// <summary>
        /// 推广订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单总额(元),扣除运费
        /// </summary>
        [JsonProperty("money")]
        public string Money { get; set; }

        /// <summary>
        /// 结算状态描述
        /// 1 待结算
        /// 2 已结算
        /// 3 余额不足
        /// 4 结算异常，等待重试
        /// 5 货到付款
        /// </summary>
        [JsonProperty("settle_state")]
        public int SettleState { get; set; }

        /// <summary>
        /// 有赞对外openId
        /// </summary>
        [JsonProperty("yz_open_id")]
        public string YZOpenId { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 分销员手机号
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 订单状态：3：待付款，5：已付款，6：已发货，100：交易完成
        /// </summary>
        [JsonProperty("state")]
        public int State { get; set; }

        /// <summary>
        /// 分销员标识符
        /// </summary>
        [JsonProperty("seller")]
        public string Seller { get; set; }

        /// <summary>
        /// 提成金额(元)
        /// </summary>
        [JsonProperty("cps_money")]
        public string CpsMoney { get; set; }

    }

    public class YouZanOrderItem
    {

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 订单号:商品id
        /// </summary>
        [JsonProperty("item_key")]
        public string ItemKey { get; set; }

        /// <summary>
        /// 商品提成比例(%)
        /// </summary>
        [JsonProperty("i_rate")]
        public string IRate { get; set; }

        /// <summary>
        /// 商品价格（元）
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品提成奖励(元)
        /// </summary>
        [JsonProperty("i_cps_money")]
        public string ICpsMoney { get; set; }

        /// <summary>
        /// 商品邀请奖励提成比例(%)
        /// </summary>
        [JsonProperty("ii_rate")]
        public string IIRate { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("num_iid")]
        public string NumIId { get; set; }

        /// <summary>
        /// 商品邀请奖励提成奖励(元)
        /// </summary>
        [JsonProperty("ii_cps_money")]
        public string IICpsMoney { get; set; }

        /// <summary>
        /// 是否参与推广，0：不参与，1：参与
        /// </summary>
        [JsonProperty("is_join")]
        public string IsJoin { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("num")]
        public string Amount { get; set; }

    }
}
