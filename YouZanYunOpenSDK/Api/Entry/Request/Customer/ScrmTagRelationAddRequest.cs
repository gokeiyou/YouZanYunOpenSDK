using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 给客户打标 请求参数实体
    /// </summary>
    public class ScrmTagRelationAddRequest : YouZanRequest
    {
        /// <summary>
        /// 账户ID
        /// </summary>
        [ApiField("account_id")]
        public string AccountId { get; set; }
        /// <summary>
        /// 帐号类型。
        /// 目前支持以下选项（只支持传一种）：
        /// FansID：自有粉丝ID;
        /// Mobile：手机号;
        /// YouZanAccount：有赞账号;
        /// OpenUserId：三方自身账号;
        /// WeiXinOpenId：微信openId;
        /// YzOpenId：有赞OpenId
        /// </summary>
        [ApiField("account_type")]
        public string AccountType { get; set; }
    }
}