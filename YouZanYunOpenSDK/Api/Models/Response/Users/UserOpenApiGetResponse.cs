using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Users
{
    /// <summary>
    /// 获取有赞openId返回实体
    /// </summary>
    public class UserOpenApiGetResponse
    {
        /// <summary>
        /// 更新时间，时间戳，单位：ms
        /// </summary>
        /// <example>1562322356000</example>
        [JsonProperty("updated_at")]
        public long UpdatedTimestamp { get; set; }
        /// <summary>
        /// 创建时间，时间戳，单位：ms
        /// </summary>
        /// <example>1562322356000</example>
        [JsonProperty("created_at")]
        public long CreatedTimestamp { get; set; }
        /// <summary>
        /// 有赞用户Id，在有赞平台账号平台下唯一。user_id，yz_uid，account_id都是账号id（后续会废弃推荐使用yz_open_id）
        /// </summary>
        /// <example>4699645</example>
        [JsonProperty("user_id")]
        public long UserId { get; set; }
        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id
        /// </summary>
        /// <example>3hf8Fb8I596768747084054528</example>
        [JsonProperty("yz_open_id")]
        public string OpenId { get; set; }
    }
}
