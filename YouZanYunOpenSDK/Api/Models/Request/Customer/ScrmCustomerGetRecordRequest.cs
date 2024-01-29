using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 权益卡购卡记录 请求实体
    /// </summary>
    public class ScrmCustomerGetRecordRequest : YouZanRequest
    {
        /// <summary>
        /// 会员卡号，可通过查询用户下会员卡列表接口youzan.scrm.customer.card.list获得
        /// </summary>
        /// <example>306248981525655685</example>
        [ApiField("card_no")]
        public string CardNo { get; set; }
    }
}
