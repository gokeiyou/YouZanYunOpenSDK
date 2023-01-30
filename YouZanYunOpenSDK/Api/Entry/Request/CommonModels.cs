using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request
{

    public abstract class OpenIdModel : YouZanRequest
    {
        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id。推荐使用
        /// </summary>
        /// <example>LnhGm4rh576452722916618240</example>
        [ApiField("yz_open_id")]
        public string YzOpenId { get; set; }
    }

    /// <summary>
    /// 用户
    /// </summary>
    public abstract class ParamUser : YouZanRequest
    {
        /// <summary>
        /// 帐号类型（支持的用户账号类型) ;
        /// 2-手机号;
        /// 3-三方帐号(原open_user_id:三方App用户ID，该参数仅限购买App开店插件的商家使用) ;
        /// 5-有赞用户id，用户在有赞的唯一id（即客户在有赞的yz_open_id）
        /// </summary>
        /// <example>2</example>
        [ApiField("account_type")]
        public int AccountType { get; set; }
        /// <summary>
        /// 帐号ID
        /// </summary>
        /// <example>12399245670</example>
        [ApiField("account_id")]
        public string AccountId { get; set; }
    }
}
