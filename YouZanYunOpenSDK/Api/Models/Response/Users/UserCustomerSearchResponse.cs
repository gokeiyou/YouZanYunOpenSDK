using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Users
{
    /// <summary>
    /// 获取客户列表返回参数
    /// </summary>
    public class UserCustomerSearchResponse
    {
        /// <summary>
        /// 客户信息列表
        /// </summary>
        [JsonProperty("record_list")]
        public List<UserCustomerSearchRecordInfo> RecordList { get; set; }

        /// <summary>
        /// 列表总数
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }
    }
}