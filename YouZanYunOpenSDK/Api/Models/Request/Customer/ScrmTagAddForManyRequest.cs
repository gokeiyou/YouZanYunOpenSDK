using System.Collections.Generic;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 给多个客户批量打标签接口 请求参数
    /// </summary>
    public class ScrmTagAddForManyRequest
    {
        /// <summary>
        /// 请求参数集合
        /// </summary>
        [ApiField("account_list_request_dtos")]
        public List<AccountListRequestDto> AccountListRequestList { get; set; }
    }

    public class AccountListRequestDto
    {
        /// <summary>
        /// 标签参数集合
        /// </summary>
        [ApiField("user_tag_creates")]
        public List<UserTagCreateDto> TagList { get; set; }
        /// <summary>
        /// 账号参数集合
        /// </summary>
        [ApiField("account")]
        public ParamUser Account { get; set; }
    }

    public class UserTagCreateDto
    {
        /// <summary>
        /// 标签名称。需要在店铺下面已经存在的标签才能打标成功
        /// </summary>
        [ApiField("tag_name")]
        public string TagName { get; set; }
    }
}