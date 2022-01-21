using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    public class UsersWeixinFollowerTagsGetReqeust : YouZanRequest
    {
        /// <summary>
        /// 微信粉丝用户的openid
        /// </summary>
        /// <example>o2xT-wZ3xvzlhAbtYmk68NpA-yI8</example>
        [ApiField("weixin_openid")]
        public string WeixinOpenId { get; set; }
        /// <summary>
        /// 微信粉丝用户ID。调用时，参数 weixin_openid 和 fans_id 选其一即可
        /// </summary>
        /// <example>5357260342</example>
        [ApiField("fans_id")]
        public long FansId { get; set; }
    }
}
