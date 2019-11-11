using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Salesman
{
    public class SalesmanAccountGetResponse
    {

        /// <summary>
        /// 邀请方手机号
        /// </summary>
        [JsonProperty("from_buyer_mobile")]
        public string FromBuyerMobile { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("nickname")]
        public string NickName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// 标识码
        /// </summary>
        [JsonProperty("seller")]
        public string Seller { get; set; }

        /// <summary>
        /// 累计成交金额
        /// </summary>
        [JsonProperty("money")]
        public string Money { get; set; }

        /// <summary>
        /// 自有粉丝Id
        /// </summary>
        [JsonProperty("fans_id")]
        public long FansId { get; set; }

        /// <summary>
        /// 累计成交笔数
        /// </summary>
        [JsonProperty("order_num")]
        public int OrderNum { get; set; }

    }
}
