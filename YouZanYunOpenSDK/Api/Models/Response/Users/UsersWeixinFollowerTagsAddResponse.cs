using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Users
{
    /// <summary>
    /// 根据微信粉丝用户的 weixin_openid 或 fans_id 绑定对应的标签 返回值
    /// </summary>
    /// <see cref="https://doc.youzanyun.com/detail/API/0/103"/>
    public class UsersWeixinFollowerTagsAddResponse
    {
        /// <summary>
        /// 微信粉丝用户信息
        /// </summary>
        [JsonProperty("user")]
        public WeixinFollower User { get; set; }
    }

    public class WeixinFollower
    {
        /// <summary>
        /// 当前积分
        /// </summary>
        /// <example>477</example>
        [JsonProperty("points")]
        public long Points { get; set; }
        /// <summary>
        /// 微信粉丝用户ID
        /// </summary>
        /// <example>4555805017</example>
        [JsonProperty("user_id")]
        public long UserId { get; set; }
        /// <summary>
        /// 关注时间，时间戳，单位秒
        /// </summary>
        /// <example>1467949853</example>
        [JsonProperty("follow_time")]
        public long FollowTime { get; set; }
        /// <summary>
        /// 用户标签
        /// </summary>
        [JsonProperty("tags")]
        public List<FollowerTag> Tags { get; set; }
        /// <summary>
        /// 微信粉丝用户的openid，可用于微信Api
        /// </summary>
        /// <example>oHIuujg9Ueni6N1Vc_Eh-4Oc1c04</example>
        [JsonProperty("weixin_openid")]
        public string WeixinOpenId { get; set; }
        /// <summary>
        /// 粉丝会员等级
        /// </summary>
        [JsonProperty("level_info")]
        public LevelInfo LevelInfo { get; set; }
        /// <summary>
        /// 微信粉丝用户的unionid，可用于微信Api
        /// </summary>
        /// <example>oT7umjigTGai0qu6RAmaQpLZi1VY</example>
        [JsonProperty("union_id")]
        public string UnionId { get; set; }
        /// <summary>
        /// 所在城市
        /// </summary>
        /// <example>杭州</example>
        [JsonProperty("city")]
        public string City { get; set; }
        /// <summary>
        /// 微信粉丝用户的昵称
        /// </summary>
        /// <example>you</example>
        [JsonProperty("nick")]
        public string NickName { get; set; }
        /// <summary>
        /// 成交订单笔数
        /// </summary>
        /// <example>20</example>
        [JsonProperty("traded_num")]
        public int TradedNum { get; set; }
        /// <summary>
        /// 性别。可选值：m(男)，f(女)。未知则为空
        /// </summary>
        /// <example>f</example>
        [JsonProperty("sex")]
        public string Sex { get; set; }
        /// <summary>
        /// 微信粉丝用户的头像Url
        /// </summary>
        /// <example>http://thirdwx.qlogo.cn/mmopen/vi_32/Q0j4TwGTfTJ8eh5zetg7dibv6cdEZBU0oRyoxKjRwVoiap8KIGbFVWk4TMZxqrb3ia9Sq73PiadOV12mt37AWVDF4A/132</example>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
        /// <summary>
        /// 成交订单总额，单位元
        /// </summary>
        /// <example>24.76</example>
        [JsonProperty("traded_money")]
        public string TradedMoney { get; set; }
        /// <summary>
        /// 是否关注
        /// </summary>
        /// <example>true</example>
        [JsonProperty("is_follow")]
        public bool IsFollow { get; set; }
    }

    public class FollowerTag
    {
        /// <summary>
        /// 标签id
        /// </summary>
        /// <example>1553244327546</example>
        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// 用户标签
        /// </summary>
        /// <example>测试</example>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
