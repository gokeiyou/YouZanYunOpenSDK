using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Api.Constant;

namespace YouZan.Open.Api.Entry.Response.Users
{
    public class UsersInfoQueryResponse
    {
        /// <summary>
        /// 根据查询请求，返回指定的平台帐号信息
        /// </summary>
        [JsonProperty("user_list")]
        public List<UserListBase> UserList { get; set; }
        /// <summary>
        /// 最新的用户信息
        /// </summary>
        [JsonProperty("latest_info")]
        public LatestInfo LatestInfo { get; set; }
    }

    /// <summary>
    /// 平台账号信息
    /// </summary>
    public class UserListBase
    {
        /// <summary>
        /// 微信公众号、小程序粉丝特有
        /// </summary>
        [JsonProperty("wechat_info")]
        public WechatInfo WechatInfo { get; set; }
        /// <summary>
        /// 基本信息，所有平台通用
        /// </summary>
        [JsonProperty("primitive_info")]
        public PrimitiveInfo PrimitiveInfo { get; set; }
        /// <summary>
        /// mobile帐号信息
        /// </summary>
        [JsonProperty("mobile_info")]
        public MobileInfo MobileInfo { get; set; }
        /// <summary>
        /// 平台帐号信息，包括微信、快手等三方平台
        /// </summary>
        [JsonProperty("platform_info")]
        public PlatformInfo PlatformInfo { get; set; }
    }

    /// <summary>
    /// 微信公众号、小程序粉丝特有
    /// </summary>
    public class WechatInfo
    {
        /// <summary>
        /// 账号类型：1-公众号、2-小程序
        /// </summary>
        /// <example>2</example>
        [JsonProperty("wechat_type")]
        public WechatType WechatType { get; set; }
        /// <summary>
        /// 公众号粉丝特有，0表示取消关注，1表示关注，2表示是静默授权登录产生的粉丝，没有关注也没有取关
        /// </summary>
        /// <example>1</example>
        [JsonProperty("is_fans")]
        public int IsFans { get; set; }
        /// <summary>
        /// 关注时间，公众号粉丝特有，Unix时间戳，单位：秒
        /// </summary>
        /// <example>1610358027</example>
        [JsonProperty("follow_time")]
        public long FollowTime { get; set; }
        /// <summary>
        /// 粉丝最后对话时间,公众号粉丝特有，Unix时间戳，单位：秒
        /// </summary>
        /// <example>1610358027</example>
        [JsonProperty("last_talk_time")]
        public int LastTalkTime { get; set; }
        /// <summary>
        /// 微信全局标识
        /// </summary>
        /// <example>oyzyK1Ma95qZtmRvUTFXqoNyQ3mUliq</example>
        [JsonProperty("union_id")]
        public int UnionId { get; set; }
        /// <summary>
        /// 取关时间，公众号粉丝特有，Unix时间戳，单位：秒
        /// </summary>
        /// <example>1589351498</example>
        [JsonProperty("unfollow_time")]
        public int UnfollowTime { get; set; }
    }

    /// <summary>
    /// 基本信息，所有平台通用
    /// </summary>
    public class PrimitiveInfo
    {
        /// <summary>
        /// 性别
        /// </summary>
        /// <example>1</example>
        [JsonProperty("gender")]
        public Gender Gender { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        /// <example>中国</example>
        [JsonProperty("country")]
        public string Country { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        /// <example>浙江省</example>
        [JsonProperty("province")]
        public string Province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        /// <example>杭州市</example>
        [JsonProperty("city")]
        public string City { get; set; }
        /// <summary>
        /// 用户创建时间，时间格式：yyyy-MM-dd-HH-mm-ss；和platform_type类型对应
        /// </summary>
        /// <example>2020-11-11 20:11:11</example>
        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }
        /// <summary>
        /// 用户最后更新时间，时间格式：yyyy-MM-dd-HH-mm-ss；和platform_type类型对应
        /// </summary>
        /// <example>2020-11-11 20:11:11</example>
        [JsonProperty("updated_time")]
        public string UpdatedTime { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        /// <example>dy</example>
        [JsonProperty("nick_name")]
        public string NickName { get; set; }
        /// <summary>
        /// 平台类型，0-手机帐号；1-微信H5帐号；其他表示微信小程序
        /// </summary>
        /// <example>0</example>
        [JsonProperty("platform_type")]
        public int PlatformType { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        /// <example>https://dn-kdt-img.qbox.me/upload_files/avatar.png</example>
        [JsonProperty("avatar")]
        public int Avatar { get; set; }
        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id
        /// </summary>
        /// <example>LnhGm4rh576452722916618240</example>
        [JsonProperty("yz_open_id")]
        public int YzOpenId { get; set; }
    }

    /// <summary>
    /// mobile帐号信息
    /// </summary>
    public class MobileInfo
    {
        /// <summary>
        /// 用户手机号
        /// </summary>
        /// <example>138****3622</example>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }
    }

    /// <summary>
    /// 平台帐号信息，包括微信、快手等三方平台
    /// </summary>
    public class PlatformInfo
    {
        /// <summary>
        /// 平台帐号唯一标识，如QQ、微博、三方APP标识
        /// </summary>
        /// <example>oHIuujqttsLcr9LxPfu4aKaEkNlcliq</example>
        [JsonProperty("weixin_open_id")]
        public string WeixinOpenId { get; set; }
    }

    /// <summary>
    /// 最新的用户信息
    /// </summary>
    public class LatestInfo
    {
        /// <summary>
        /// 头像，和B端店铺后台客户详情头像一致，推荐使用
        /// </summary>
        /// <example>https://dn-kdt-img.qbox.me/upload_files/avatar.png</example>
        public string Avatar { get; set; }
        /// <summary>
        /// 昵称和B端店铺后台客户详情昵称一致，推荐使用
        /// </summary>
        /// <example>dy</example>
        public string NickName { get; set; }
    }
}
