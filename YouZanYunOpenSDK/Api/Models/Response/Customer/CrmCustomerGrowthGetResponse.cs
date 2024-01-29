using Newtonsoft.Json;

namespace YouZan.Open.Api.Models.Response.Customer
{
    /// <summary>
    /// 获取客户成长值 返回参数
    /// </summary>
    public class CrmCustomerGrowthGetResponse
    {
        /// <summary>
        /// 当前成长值
        /// </summary>
        [JsonProperty("growth")]
        public long Growth { get; set; }
    }
}