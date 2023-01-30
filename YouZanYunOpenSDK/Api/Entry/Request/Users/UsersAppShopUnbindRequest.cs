using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    /// <summary>
    /// 查询app开店的用户信息参数实体
    /// </summary>
    public class UsersAppShopUnbindRequest : YouZanRequest
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [ApiField("param")]
        public OpenIdModel Param { get; set; }
    }
}
