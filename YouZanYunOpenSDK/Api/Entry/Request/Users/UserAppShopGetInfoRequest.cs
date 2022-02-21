using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    /// <summary>
    /// 查询app开店的用户信息参数实体
    /// </summary>
    public class UserAppShopGetInfoRequest : YouZanRequest
    {
        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id。推荐使用
        /// </summary>
        /// <example>LnhGm4rh576452722916618240</example>
        [ApiField("yz_open_id")]
        public string YzOpenId { get; set; }
    }
}
