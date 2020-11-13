using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Trade
{
    public class TradeMemoUpdateRequest :YouZanRequest
    {
        [ApiField("flag")]
        public string Flag { get; set; }

        [ApiField("memo")]
        public string Memo { get; set; }

        [ApiField("tid")]
        public string Tid { get; set; }

    }
}