using System.Collections.Generic;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 删除标签请求实体
    /// </summary>
    public class ScrmTagRelationDeleteRequest : YouZanRequest
    {
        /// <summary>
        /// 账户ID
        /// </summary>
        [ApiField("account_id")]
        public string AccountId { get; set; }
        /// <summary>
        /// 帐号类型。目前支持以下选项（只支持传一种）：
        /// FansID：自有粉丝ID，
        /// Mobile：手机号，
        /// YouZanAccount：有赞账号，
        /// OpenUserId：三方自身账号，
        /// WeiXinOpenId：微信openId，
        /// YzOpenId：有赞OpenId
        /// </summary>
        [ApiField("account_type")]
        public string AccountType { get; set; }
        /// <summary>
        /// 标签集合，最大支持一次请求传入20个标签
        /// </summary>
        [ApiField("tags")]
        public List<ScrmTagRelationDeleteTag> Tags { get; set; }
    }

    /// <summary>
    /// 标签信息
    /// </summary>
    public class ScrmTagRelationDeleteTag
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        [ApiField("tag_name")]
        public string TagName { get; set; }
    }
}