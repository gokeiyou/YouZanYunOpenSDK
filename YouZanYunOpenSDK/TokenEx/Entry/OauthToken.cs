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
            public long? Expires { get; set; }

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
                    if (this.Expires == null)
                        return new DateTime(2099, 12, 31, 23, 59, 59);
                    var startTime = new DateTime(1970, 1, 1);
                    var ts = new TimeSpan(this.Expires.Value * 10000);
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
