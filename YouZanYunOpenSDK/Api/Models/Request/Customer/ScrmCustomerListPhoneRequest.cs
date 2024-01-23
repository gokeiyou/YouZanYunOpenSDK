using System.Collections.Generic;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 根据手机号批量查询客户信息 请求参数
    /// </summary>
    public class ScrmCustomerListPhoneRequest : YouZanRequest
    {
        /// <summary>
        /// 手机号码，一次最多支持50个手机号码
        /// </summary>
        [ApiField("phones")]
        public List<string> Phones { get; set; }
    }
}