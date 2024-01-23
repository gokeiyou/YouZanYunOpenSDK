using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    public class ScrmCustomerCreateResponse
    {

        /// <summary>
        /// 账号ID
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 帐号类型
        /// 目前支持以下选项（只支持传一种）
        /// FansID：自有粉丝
        /// Mobile：手机号
        /// YouZanAccount：有赞账号
        /// </summary>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

    }
}
