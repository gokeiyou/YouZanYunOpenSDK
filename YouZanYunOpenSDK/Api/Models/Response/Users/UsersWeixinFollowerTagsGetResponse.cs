using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Users
{
    public class UsersWeixinFollowerTagsGetResponse
    {
        /// <summary>
        /// 该粉丝的标签集合
        /// </summary>
        [JsonProperty("tags")]
        public List<WeixinFollowerTag> Tags { get; set; }
    }

    /// <summary>
    /// 粉丝标签信息
    /// </summary>
    public class WeixinFollowerTag
    {
        /// <summary>
        /// 标签名
        /// </summary>
        /// <example>标签名</example>
        [JsonProperty("tag_id")]
        public int TagId { get; set; }
        /// <summary>
        /// 标签id
        /// </summary>
        /// <example>1544166479128</example>
        [JsonProperty("tag_name")]
        public string TagName { get; set; }
    }
}
