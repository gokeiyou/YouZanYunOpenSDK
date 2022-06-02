using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 批量获取客户成长值 返回值实体
    /// </summary>
    public class CrmCustomerGrowthListResponse
    {
        /// <summary>
        /// 客户的成长值信息
        /// </summary>
        [JsonProperty("growths")]
        public Dictionary<string, long> Growths { get; set; }
    }
}