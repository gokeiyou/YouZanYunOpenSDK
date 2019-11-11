using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Salesman
{
    public class SalesmanAccountScoreSearchResponse
    {

        [JsonProperty("accumulations")]
        public List<AccumulationItem> Items { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

    }

    public class AccumulationItem
    {

        /// <summary>
        /// 已结算佣金
        /// </summary>
        [JsonProperty("settle_money")]
        public string SettleMoney { get; set; }

        /// <summary>
        /// 自动结算推广订单金额
        /// </summary>
        [JsonProperty("auto_settle_order_amount")]
        public string AutoSettleOrderAmount { get; set; }

        /// <summary>
        /// 自动结算推广订单数
        /// </summary>
        [JsonProperty("auto_settle_order_num")]
        public int auto_settle_order_num { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("nickname")]
        public string NickName { get; set; }

        /// <summary>
        /// 人工结算推广订单金额
        /// </summary>
        [JsonProperty("manual_settle_order_amount")]
        public string ManualSettleOrderAmount { get; set; }

        /// <summary>
        /// 待结算佣金
        /// </summary>
        [JsonProperty("wait_settle_money")]
        public string WaitSettleMoney { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 人工结算推广订单数
        /// </summary>
        [JsonProperty("manual_settle_order_num")]
        public int ManualSettleOrderNum { get; set; }
    }
}
