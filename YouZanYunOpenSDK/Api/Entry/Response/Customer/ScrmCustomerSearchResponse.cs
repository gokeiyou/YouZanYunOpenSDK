using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    public class ScrmCustomerSearchResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }
        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 客户信息项
        /// </summary>
        [JsonProperty("items")]
        public List<ScrmCustomerInfo> Items { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }
    }

    public class ScrmCustomerInfo
    {
        /// <summary>
        /// 粉丝类型
        /// </summary>
        [JsonProperty("fans_type")]
        public short FansType { get; set; }
        /// <summary>
        /// 归属门店店铺ID
        /// </summary>
        [JsonProperty("ascription_kdt_id")]
        public long AscriptionKdtId { get; set; }
        /// <summary>
        /// 客户手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }
        /// <summary>
        /// 微信昵称
        /// </summary>
        [JsonProperty("wx_nickname")]
        public string WeixinNickName { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 粉丝ID
        /// </summary>
        [JsonProperty("fans_id")]
        public long FansId { get; set; }
    }
}
