using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    public class ScrmCustomerPointsGetResponse
    {
        /// <summary>
        /// 当前积分值
        /// </summary>
        [JsonProperty("point")]
        public long Point { get; set; }
    }
}