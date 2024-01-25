using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    public class ScrmCardDeleteRequest : YouZanRequest
    {
        /// <summary>
        /// 权益卡唯一标识
        /// </summary>
        /// <example>Y1yla6con9yq80</example>
        [ApiField("card_alias")]
        public string CardAlias { get; set; }
    }
}