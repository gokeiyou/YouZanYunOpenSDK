using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    /// <summary>
    /// 获取有赞openId请求参数
    /// </summary>
    internal class UserOpenApiGetRequest : YouZanRequest
    {
        /// <summary>
        /// 有赞用户Id，在有赞平台账号平台下唯一。user_id，yz_uid，account_id都是账号id（后续会废弃推荐使用yz_open_id）
        /// </summary>
        /// <example>4699645</example>
        [ApiField("user_id")]
        public long UserId { get; set; }
    }
}
