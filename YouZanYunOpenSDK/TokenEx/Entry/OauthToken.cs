using System;
using Newtonsoft.Json;

namespace YouZan.Open.TokenEx
{
    public class OauthToken
    {

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("success")]
        public string Success { get; set; }

        [JsonProperty("data")]
        public Object Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        //message 
        // Object--->TokenData

        public class TokenData
        {
            public string Key { get; set; }
            [JsonProperty("expires")]
            public long Expires { get; set; }

            [JsonProperty("access_token")]
            public string Token { get; set; }

            [JsonProperty("authority_id")]
            public string Authority { get; set; }

            [JsonProperty("refresh_token")]
            public string RefRefreshToken { get; set; }

            public string Message { get; set; }

            public DateTime ExpiresTime
            {
                get {
                    DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
                    TimeSpan ts = new TimeSpan(this.Expires * 10000);
                    return startTime.Add(ts);
                }
            }

            public static TokenData GetData(string key, Func<TokenData> func)
            {

                return null;
            }

            public void Save(string key)
            {
                this.Key = key;
            }
        }
    }




}
