using System;
using System.Collections.Generic;
using YouZan.Open.Http;
using Newtonsoft.Json;
using static YouZan.Open.TokenEx.OauthToken;

namespace YouZan.Open.TokenEx
{
    public class Silent : AbstractOauth
    {
        private string _GrantId;

        public Silent(string clientId, string clientSecret, string grantId) : base(clientId, clientSecret)
        {
            this._GrantId = grantId;
        }

        public Silent(string clientId, string clientSecret) : base(clientId, clientSecret)
        {
        }

        public void SetKdtId(string grantId)
        {

            this._GrantId = grantId;
        }

        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="getNew">获取最新</param>
        /// <returns></returns>
        public override TokenData GetToken(bool getNew = false)
        {
            TokenData tokenData = null;
            if (getNew)
            {
                tokenData = GetNewTokenData();
            }
            else
            {
                tokenData = cache.GetT(this._ClientId + "_" + this._GrantId, this.GetNewTokenData);
            }


            return tokenData;
        }

        private TokenData GetNewTokenData()
        {
            TokenData tokenData = null;
            IDictionary<string, object> tokenParams = new Dictionary<string, object>
                {
                    { "client_id", _ClientId },
                    { "client_secret", _ClientSecret },
                    { "authorize_type", "silent" },
                    { "grant_id", _GrantId }
                };
            DefaultHttpClient defaultHttpClient = new DefaultHttpClient();
            string result = defaultHttpClient.Send(this.GetTokenUrl(), tokenParams, null, null);
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
            if (cache.Contains(this._ClientId + "_" + this._GrantId))
                cache.Remove(this._ClientId + "_" + this._GrantId);
            cache.Add(this._ClientId+"_"+this._GrantId, tokenData, tokenData.ExpiresTime.AddMinutes(-5));

            return tokenData;
        }
    }
}



