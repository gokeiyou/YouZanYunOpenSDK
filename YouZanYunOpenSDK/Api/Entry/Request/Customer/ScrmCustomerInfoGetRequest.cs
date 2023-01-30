using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 通过用户权益卡号获取会员信息 请求参数
    /// </summary>
    public class ScrmCustomerInfoGetRequest
    {
        /// <summary>
        /// 用户权益卡卡号，可通过查询用户下权益卡列表接口youzan.scrm.customer.card.list获得
        /// </summary>
        /// <example>305812218727787134</example>
        [ApiField("card_no")]
        public string CardNo { get; set; }
    }
}