using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Request.Customer;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Models.Request.Customer
{
    /// <summary>
    /// 获取客户成长值 请求参数
    /// </summary>
    public class CrmCustomerGrowthGetRequest : YouZanRequest
    {
        /// <summary>
        /// 是否需要走扩展点，默认：true
        /// </summary>
        [ApiField("is_do_extpoint")]
        public bool IsDoExtPoint { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        [ApiField("user")]
        public User User { get; set; }
    }
}