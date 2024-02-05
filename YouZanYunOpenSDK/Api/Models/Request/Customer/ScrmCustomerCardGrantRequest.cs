using Newtonsoft.Json;
using YouZan.Open.Api.Entry.Request.Customer;

namespace YouZan.Open.Api.Models.Request.Customer
{
    /// <summary>
    /// 给用户发放权益卡
    /// </summary>
    public class ScrmCustomerCardGrantRequest
    {
        /// <summary>
        /// 管理员id，如果是管理员发放场景，传有赞的userId，否则，adminId传0，注:目前user_id 一般接口已经不吐出了，这个字段可以不传
        /// </summary>
        [JsonProperty("admin_id")]
        public long AdminId { get; set; }

        /// <summary>
        /// 卡别名，不能自定义，需要从接口youzan.scrm.card.list 中获取。
        /// </summary>
        [JsonProperty("card_alias")]
        public string CardAlias { get; set; }

        /// <summary>
        /// 客户信息
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }
    }
}