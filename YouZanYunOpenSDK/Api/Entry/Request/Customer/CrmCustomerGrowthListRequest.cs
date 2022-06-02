using System.Collections.Generic;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    
    public class CrmCustomerGrowthListRequest : YouZanRequest
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [ApiField("params")]
        public CrmCustomerGrowthListParams Params { get; set; }
    }

    /// <summary>
    /// 请求参数
    /// </summary>
    public class CrmCustomerGrowthListParams
    {
        /// <summary>
        /// 帐号类型（支持的用户账号类型) ;
        /// 2-手机号;
        /// 5-有赞用户id，用户在有赞的唯一id（即客户在有赞的yz_open_id）
        /// </summary>
        /// <example>2</example>
        [ApiField("account_type")]
        public int AccountType { get; set; }

        /// <summary>
        /// 用户列表，最大支持一次查询50条客户信息
        /// 手机号类型传值示例：["137****2009","157****8975"]
        /// yz_open_id传值示例：["jn6L6I1n641201646377967616","LnhGm4rh576452722916618240"]
        /// </summary>
        public List<string> Users { get; set; }
    }
}