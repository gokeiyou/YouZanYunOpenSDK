using System;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 根据手机号批量查询客户信息 返回参数实体
    /// </summary>
    public class ScrmCustomerListPhoneResponse
    {
        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("label_info")]
        public ScrmCustomerListPhoneLabelInfo LabalInfo { get; set; }
        /// <summary>
        /// 社群信息
        /// </summary>
        [JsonProperty("social_info")]
        public ScrmCustomerListPhoneSocialInfo SocialInfo { get; set; }
        /// <summary>
        /// 更新时间 单位:ms
        /// </summary>
        [JsonProperty("updated_time")]
        public long UpdatedTime { get; set; }
        /// <summary>
        /// 创建时间 单位:ms
        /// </summary>
        [JsonProperty("created_time")]
        public long CreatedTime { get; set; }
        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id。推荐使用
        /// </summary>
        [JsonProperty("yz_open_id")]
        public string YouzanOpenId { get; set; }
    }

    /// <summary>
    /// 标签信息
    /// </summary>
    public class ScrmCustomerListPhoneLabelInfo
    {
        /// <summary>
        /// 会员分店来源（连锁）微商城单店返回单店店铺id，连锁店铺返回网店id
        /// </summary>
        [JsonProperty("member_node_kdt_id")]
        public long MemberNodeKdtId { get; set; }
        /// <summary>
        /// 客户分店来源（连锁）微商城单店返回单店店铺id，连锁店铺返回网店id
        /// </summary>
        [JsonProperty("customer_node_kdt_id")]
        public long CustomerNodeKdtId { get; set; }
        /// <summary>
        /// 最近会员过期时间 单位:ms
        /// </summary>
        [JsonProperty("member_expired_time")]
        public long MemberExpiredTime { get; set; }
        /// <summary>
        /// 客户归属店铺，微商城单店返回单店店铺id，连锁店铺返回网店id
        /// </summary>
        [JsonProperty("node_kdt_id")]
        public long NodeKdtId { get; set; }
        /// <summary>
        /// 是否是会员的标识
        /// </summary>
        [JsonProperty("is_member")]
        public bool IsMember { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }
        /// <summary>
        /// 首次成为会员时间 单位:ms
        /// </summary>
        [JsonProperty("member_created_time")]
        public DateTime MemberCreatedTime { get; set; }
    }

    /// <summary>
    /// 社群信息
    /// </summary>
    public class ScrmCustomerListPhoneSocialInfo
    {
        /// <summary>
        /// 微信昵称
        /// </summary>
        [JsonProperty("wx_nickname")]
        public string WeixinNickname { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }
        /// <summary>
        /// 客户的微信号
        /// </summary>
        [JsonProperty("weixin")]
        public string Weixin { get; set; }
    }
    
}