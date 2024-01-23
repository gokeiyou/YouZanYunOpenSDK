using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 查询客户标签列表 请求参数
    /// </summary>
    public class ScrmTagRelationQueryRequest : YouZanRequest
    {
        /// <summary>
        /// 客户帐号
        /// </summary>
        [ApiField("account")]
        public ScrmTagRelationQueryAccount Account { get; set; }

        /// <summary>
        /// 0-只返回隐藏,1-只返回展示,2-返回全部
        /// </summary>
        [ApiField("display_type")]
        public int display_type { get; set; }

        /// <summary>
        /// 是否需要过滤禁用标签，非必传。默认过滤true
        /// </summary>
        [ApiField("filter_invalid_tag")]
        public bool filter_invalid_tag { get; set; }

        /// <summary>
        /// 是否过滤特征标签（即 标签组），非必传。默认过滤true
        /// </summary>
        [ApiField("filter_category_tag")]
        public bool filter_category_tag { get; set; }
    }

    public class ScrmTagRelationQueryAccount
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
        public int AccountType { get; set; }
    }
}