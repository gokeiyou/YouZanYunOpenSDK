using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Trade
{
    public class TradeGetRequest :YouZanRequest
    {
        /// <summary>
        /// 有赞订单号，E开头长度24位字母和数字组合
        /// </summary>
        [ApiField("tid")] 
        public string Tid { get; set; }

    }
}