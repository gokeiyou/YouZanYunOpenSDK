using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    public class UsersAccountCheckRequest : YouZanRequest
    {

        /// <summary>
        /// 帐号类型
        /// 目前支持以下选项（只支持传一种）
        /// Mobile：手机号
        /// UnionId：微信 UnionId
        /// </summary>
        [ApiField("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 账号ID
        /// </summary>
        [ApiField("account_id")]
        public string AccountId { get; set; }

    }
}
