using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 获取客户账号下权益卡列表 参数
    /// </summary>
    public class ScrmCustomerCardListRequest : YouZanRequest
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [ApiField("params")]
        public ScrmCustomerCardListParams Params { get; set; }
    }
    
    /// <summary>
    /// 参数信息
    /// </summary>
    public class ScrmCustomerCardListParams
    {
        /// <summary>
        /// 是否查询所有（false-查可用权益卡;true-查全部权益卡）默认查可用权益卡
        /// </summary>
        [ApiField("state")]
        public bool? State { get; set; }
        /// <summary>
        /// 三方应用client_id
        /// </summary>
        [ApiField("client_id")]
        public string ClientId { get; set; }
        /// <summary>
        /// 客户信息
        /// </summary>
        [ApiField("user")]
        public ParamUser User { get; set; }
        /// <summary>
        /// 页数
        /// </summary>
        [ApiField("page_no")]
        public int PageNo { get; set; }
    }
}