using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Users
{
    /// <summary>
    /// 根据关注时间段批量查询微信粉丝用户信息返回参数
    /// </summary>
    public class UsersWeixinFollowersInfoSearchResponse
    {
        /// <summary>
        /// 用户信息列表
        /// </summary>
        [JsonProperty("users")]
        public List<FollowerInfo> Users { get; set; }
        /// <summary>
        /// 搜索到的微信粉丝用户总数
        /// </summary>
        [JsonProperty("total_results")]
        public long TotalResults { get; set; }
    }

    /// <summary>
    /// 用户信息
    /// </summary>
    public class FollowerInfo
    {
        /// <summary>
        /// 粉丝会员等级信息
        /// </summary>
        [JsonProperty("level_info")]
        public LevelInfo LevelInfo { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        /// <example>中国</example>
        [JsonProperty("country")]
        public string Country { get; set; }
        /// <summary>
        /// 微信粉丝用户的昵称
        /// </summary>
        /// <example>晨曦</example>
        [JsonProperty("nick")]
        public string Nick { get; set; }
        /// <summary>
        /// 微信粉丝用户的昵称
        /// </summary>
        /// <example>http://thirdwx.qlogo.cn/mmopen/PiajxSqBRaEKH366OO1RehHRW5Oc8qcdEts8zK3YR32dxMxDcQuNyTC7icFib1t3vAZRUUyueNRzzHgiatzNdVwplw/132</example>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
        /// <summary>
        /// 是否关注公众号
        /// </summary>
        /// <example>ture</example>
        [JsonProperty("is_follow")]
        public bool IsFollow { get; set; }
        /// <summary>
        /// 微信粉丝用户ID
        /// </summary>
        /// <example>10001097</example>
        [JsonProperty("user_id")]
        public long UserId { get; set; }
        /// <summary>
        /// 成交订单笔数（当入参fields字段传入"trade"枚举值才会返回该字段。）
        /// </summary>
        /// <example>2</example>
        [JsonProperty("traded_num")]
        public int TradedNum { get; set; }
        /// <summary>
        /// 成交订单总额。单位：元。（当入参fields字段传入"trade"枚举值才会返回该字段。）
        /// </summary>
        /// <example>343</example>
        [JsonProperty("trade_money")]
        public int TradeMoney { get; set; }
        /// <summary>
        /// 微信粉丝用户的openid，可用于微信Api
        /// </summary>
        /// <example>oTtVis-gDTz5wj2Y15NSRr0vnG3E</example>
        [JsonProperty("weixin_open_id")]
        public string WeixinOpenId { get; set; }
        /// <summary>
        /// 微信粉丝用户的openid，可用于微信Api
        /// </summary>
        /// <example>1493188606</example>
        [JsonProperty("follow_time")]
        public string FollowTime { get; set; }
        /// <summary>
        /// 微信粉丝用户的openid，可用于微信Api
        /// </summary>
        /// <example>杭州</example>
        [JsonProperty("city")]
        public string City { get; set; }
        /// <summary>
        /// 当前积分（当入参fields字段传入"points"枚举值才会返回该字段。）
        /// </summary>
        /// <example>345</example>
        [JsonProperty("points")]
        public long Points { get; set; }
        /// <summary>
        /// 性别。可选值：m(男)，f(女)。未知则为空
        /// </summary>
        /// <example>m</example>
        [JsonProperty("sex")]
        public string Sex { get; set; }
    }

    /// <summary>
    /// 粉丝会员等级的数据结构
    /// </summary>
    public class LevelInfo
    {
        /// <summary>
        /// 会员等级id
        /// </summary>
        /// <example>23</example>
        [JsonProperty("level_id")]
        public long LevelId { get; set; }
        /// <summary>
        /// 会员等级名
        /// </summary>
        /// <example>vpi1</example>
        [JsonProperty("level_name")]
        public string LevelName { get; set; }
    }
}
