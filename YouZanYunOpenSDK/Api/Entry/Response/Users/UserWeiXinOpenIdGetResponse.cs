using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Users
{
    public class UserWeiXinOpenIdGetResponse
    {

        /// <summary>
        /// 微信open_id
        /// </summary>
        [JsonProperty("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 微信union_id
        /// </summary>
        [JsonProperty("union_id")]
        public string UnionId { get; set; }

        /// <summary>
        /// 粉丝关注状态（2静默授权，1关注，0已取关）
        /// </summary>
        [JsonProperty("is_fans")]
        public int is_fans { get; set; }

    }
}
