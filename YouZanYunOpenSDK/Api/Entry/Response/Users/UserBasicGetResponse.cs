using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Users
{
    public class UserBasicGetResponse
    {
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("nick_name")]
        public string NickName { get; set; }

        [JsonProperty("yz_open_id")]
        public string YzOpenId { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

    }
}