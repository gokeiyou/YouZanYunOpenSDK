using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YouZan.Open.Api.Constant;
using YouZan.Open.Http;
using static YouZan.Open.TokenEx.OauthToken;

namespace YouZan.Open.TokenEx.Type
{
    public class RefreshToken : AbstractOauth
    {
        public string FreshToken { get; set; }

        public string Scope { get; set; }


        public RefreshToken(string clientId, string clientSecret) : base(clientId, clientSecret){ }

        public override TokenData GetToken(bool getNew = false)
        {
            var tokenData = getNew ? GetNewTokenData() : Cache.GetT(ClientId, GetNewTokenData);
            
            return tokenData;
        }

        public TokenData GetNewTokenData()
        {
            TokenData tokenData = null;
            IDictionary<string, object> tokenParams = new Dictionary<string, object>
            {
                { "client_id", ClientId },
                { "client_secret", ClientSecret },
                { "authorize_type", "refresh_token" },
                { "refresh_token", FreshToken },
                { "scope", Scope }
            };
            DefaultHttpClient defaultHttpClient = new DefaultHttpClient();
            string result = defaultHttpClient.Send(ApiConst.TOKEN_URL, tokenParams, null, null);
            OauthToken oAuthToken = JsonConvert.DeserializeObject<OauthToken>(result);
            if (oAuthToken.Data == null)
            {
                tokenData = new TokenData
                {
                    Message = result
                };
                return tokenData;
            }
            string data = oAuthToken.Data.ToString();
            tokenData = JsonConvert.DeserializeObject<TokenData>(data);

            // Token添加缓存
            if (Cache.Contains(ClientId))
                Cache.Remove(ClientId);
            Cache.Add(ClientId, tokenData, tokenData.ExpiresTime.AddMinutes(-5));

            return tokenData;
        }
    }
}
