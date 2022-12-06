using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YouZan.Open.Http;
using static YouZan.Open.TokenEx.OauthToken;

namespace YouZan.Open.TokenEx.Type
{
    public class CertificateToke : AbstractOauth
    {
        public CertificateToke(string clientId, string clientSecret) : base(clientId, clientSecret) { }


        public override TokenData GetToken(bool getNew = false)
        {
            var tokenData = getNew ? GetNewTokenData() : cache.GetT(_ClientId, GetNewTokenData);
            return tokenData;
        }

        public TokenData GetNewTokenData()
        {
            TokenData tokenData;
            IDictionary<string, object> tokenParams = new Dictionary<string, object>
            {
                { "client_id", _ClientId },
                { "client_secret", _ClientSecret },
                { "authorize_type", "certificate" }
            };
            DefaultHttpClient defaultHttpClient = new DefaultHttpClient();
            string result = defaultHttpClient.Send(GetTokenUrl(), tokenParams, null, null);
            OauthToken oAuthToken = JsonConvert.DeserializeObject<OauthToken>(result);
            if (oAuthToken.Data == null)
            {
                tokenData = new TokenData
                {
                    Message = result
                };
                return tokenData;
            }
            var data = oAuthToken.Data.ToString();
            tokenData = JsonConvert.DeserializeObject<TokenData>(data);

            // Token添加缓存
            if (cache.Contains(_ClientId))
                cache.Remove(_ClientId);
            cache.Add(_ClientId, tokenData, tokenData.ExpiresTime.AddMinutes(-5));

            return tokenData;
        }
    }
}
