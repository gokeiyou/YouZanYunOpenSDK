using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Users
{
    /// <summary>
    /// 根据微信粉丝用户的 weixin_openid 或 fans_id 删除对应的标签 返回结果
    /// </summary>
    public class UsersWeixinFollowerTagsDeleteResponse
    {
        /// <summary>
        /// 删除是否成功
        /// </summary>
        /// <example>true</example>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }
}
