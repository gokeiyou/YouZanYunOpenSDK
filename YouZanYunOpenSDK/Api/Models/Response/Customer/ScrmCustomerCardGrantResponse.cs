using Newtonsoft.Json;

namespace YouZan.Open.Api.Models.Response.Customer
{
    /// <summary>
    /// 给用户发放权益卡 响应参数实体
    /// </summary>
    public class ScrmCustomerCardGrantResponse
    {
        /// <summary>
        /// 权益卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 激活URL，当客户不属于店铺下客户的时候会返回，可以把激活链接发给客户进行激活领取
        /// </summary>
        [JsonProperty("validate_url")]
        public string ValidateUrl { get; set; }

        /// <summary>
        /// 是否成功；true:成功 false：失败
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }
}