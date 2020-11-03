using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    public class UserBasicGetRequest :YouZanRequest
    {

        [ApiField("country_code")]
        public string CountryCode { get; set; }

        [ApiField("mobile")]
        public string Mobile { get; set; }

        [ApiField("yz_open_id")]
        public string YzOpenId { get; set; }

    }
}