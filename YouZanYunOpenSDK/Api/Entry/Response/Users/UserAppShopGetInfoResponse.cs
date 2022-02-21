using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Users
{
    public class UserAppShopGetInfoResponse
    {
        /// <summary>
        /// 平台类型，每一个APP开店有一个自己的类型，以返回数据为准
        /// </summary>
        [JsonProperty("platform_type")]
        public int PlatformType { get; set; }
        /// <summary>
        /// 平台帐号唯一标识，购买APP开店插件的，三方APP标识
        /// </summary>
        [JsonProperty("platform_user_id")]
        public string PlatformUserId { get; set; }
        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id。推荐使用
        /// </summary>
        [JsonProperty("yz_open_id")]
        public string YzOpenId { get; set; }
        /// <summary>
        /// 客户在有赞生成的fans_id
        /// </summary>
        [JsonProperty("fans_id")]
        public long FansId { get; set; }
    }
}
