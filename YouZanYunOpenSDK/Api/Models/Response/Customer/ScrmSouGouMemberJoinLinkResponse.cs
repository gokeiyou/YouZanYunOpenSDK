using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 获取店铺的办理会员页面链接 响应参数实体
    /// </summary>
    public class ScrmSouGouMemberJoinLinkResponse
    {
        [JsonProperty("share_detail")]
        public string ShareDetail { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("share_icon")]
        public string ShareIcon { get; set; }
        [JsonProperty("classid")]
        public string ClassId { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("info")]
        public string Info { get; set; }
        [JsonProperty("share_title")]
        public string ShareTitle { get; set; }
    }
}