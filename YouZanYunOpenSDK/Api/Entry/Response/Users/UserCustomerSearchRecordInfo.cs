using Newtonsoft.Json;
using YouZan.Open.Api.Constant;

namespace YouZan.Open.Api.Entry.Response.Users
{
    /// <summary>
    /// 获取客户列表 响应实体
    /// </summary>
    public class UserCustomerSearchRecordInfo
    {
        /// <summary>
        /// 微信粉丝ID，预留字段，同fans_id,建议使用下面的fans_id字段
        /// </summary>
        [JsonProperty("weixin_fans_id")]
        public long WeiXinFansId { get; set; }
        /// <summary>
        /// 粉丝id（目前fansId字段 只支持关注微信公众号粉丝的粉丝ID返回，并不支持微信小程序授权的粉丝ID。）
        /// </summary>
        [JsonProperty("fans_id")]
        public long FansId { get; set; }
        /// <summary>
        /// 成为客户的时间，时间戳格式，单位秒
        /// </summary>
        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }
        /// <summary>
        /// 成为会员的时间，时间戳格式，单位秒
        /// </summary>
        [JsonProperty("member_created_at")]
        public long MemberCreatedAt { get; set; }
        /// <summary>
        /// 性别，0:其他 1:男 2:女
        /// </summary>
        [JsonProperty("gender")]
        public YzGender Gender { get; set; }
        /// <summary>
        /// 是否是会员，0：不是 1：是
        /// </summary>
        [JsonProperty("is_member")]
        public short IsMember { get; set; }
        /// <summary>
        /// 购次
        /// </summary>
        [JsonProperty("trade_count")]
        public int TradeCount { get; set; }
        /// <summary>
        /// 推荐展示姓名(showname可以等于name、可以等于mobile、可以等于nickname，取值顺序为手机-姓名-昵称)
        /// </summary>
        [JsonProperty("show_name")]
        public string ShowName { get; set; }
        /// <summary>
        /// 客户姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 用户ID,即buyer_id
        /// </summary>
        [JsonProperty("yz_uid")]
        public long YzUid { get; set; }
        /// <summary>
        /// 用户积分
        /// </summary>
        [JsonProperty("points")]
        public long Points { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }
    }
}