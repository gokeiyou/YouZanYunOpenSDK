using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    public class CrmCustomerPointsIncreaseResponse
    {
        /// <summary>
        /// 是否成功兼容Iron此为string的'true','false'
        /// </summary>
        [JsonProperty("is_success")]
        public string IsSuccess { get; set; }

    }
}