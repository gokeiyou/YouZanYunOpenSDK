using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 获取店铺的办理会员页面链接 响应参数实体
    /// </summary>
    public class ScrmSouGouMemberJoinLinkResponse
    {
        /// <summary>
        /// 分享详情
        /// </summary>
        [JsonProperty("share_detail")]
        public string ShareDetail { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 分享图标
        /// </summary>
        [JsonProperty("share_icon")]
        public string ShareIcon { get; set; }

        /// <summary>
        /// 类别ID
        /// </summary>
        [JsonProperty("classid")]
        public string ClassId { get; set; }

        /// <summary>
        /// URL链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        [JsonProperty("info")]
        public string Info { get; set; }

        /// <summary>
        /// 分享标题
        /// </summary>
        [JsonProperty("share_title")]
        public string ShareTitle { get; set; }
    }
}