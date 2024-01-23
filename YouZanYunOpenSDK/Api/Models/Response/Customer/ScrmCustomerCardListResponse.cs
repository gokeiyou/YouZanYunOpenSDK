using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 获取客户账号下权益卡列表返回值明细
    /// </summary>
    public class ScrmCustomerCardListResponse
    {
        /// <summary>
        /// 权益卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }
        /// <summary>
        /// 权益卡别名
        /// </summary>
        [JsonProperty("card_alias")]
        public string CardAlias { get; set; }
        /// <summary>
        /// 权益卡状态(0-未激活;1-使用中;2-已退款;3-已过期;4-用户已删除;5-商家已禁用;6-管理员删除;7-系统删除;8-未生效)
        /// </summary>
        [JsonProperty("card_state")]
        public int CardState { get; set; }
        /// <summary>
        /// 有效期开始时间。时间格式：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonProperty("card_start_time")]
        public string CardStartTime { get; set; }
        /// <summary>
        /// 有效期结束时间。时间格式：yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonProperty("card_end_time")]
        public string CardEndTime { get; set; }
    }
}