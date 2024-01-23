using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Salesman
{
    public class SalesmanItemsGetResponse
    {

        [JsonProperty("items")]
        public List<SalesmanItem> Items { get; set; }

    }

    public class SalesmanItem
    {
        /// <summary>
        /// 商品提成比例(%)
        /// </summary>
        [JsonProperty("i_rate")]
        public double IRate { get; set; }

        /// <summary>
        /// 商品邀请奖励提成比例(%)
        /// </summary>
        [JsonProperty("ii_rate")]
        public double IIRate { get; set; }

        /// <summary>
        /// 商品是否参与推广，0：不参与，1：参与
        /// </summary>
        [JsonProperty("is_join")]
        public bool IsJoin { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("num_iid")]
        public long ItemId { get; set; }
    }

}
