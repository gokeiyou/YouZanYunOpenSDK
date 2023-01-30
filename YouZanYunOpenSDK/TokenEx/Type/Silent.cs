using System;
using System.Collections.Generic;
using YouZan.Open.Http;
using Newtonsoft.Json;
using static YouZan.Open.TokenEx.OauthToken;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using YouZan.Open.Api.Constant;
using YouZan.Open.Core;

namespace YouZan.Open.TokenEx
{
    public class Silent : AbstractOauth
    {
        private string _grantId;

        private readonly string _cacheKey;

        public Silent(string clientId, string clientSecret, string grantId) : base(clientId, clientSecret)
        {
            _grantId = grantId;
            _cacheKey = $"{clientId}_{grantId}";
        }

        public Silent(string clientId, string clientSecret) : base(clientId, clientSecret)
        {
        }

        public void SetKdtId(string grantId)
        {

            this._grantId = grantId;
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
                tokenData = YouZanConfig.SaveAccessTokenToDB ? YouZanAccessToken.GetData(_cacheKey, GetNewTokenData) : Cache.GetT(_cacheKey, GetNewTokenData);
            }
            
            return tokenData;
        }

        private TokenData GetNewTokenData()
        {
            TokenData tokenData = null;
            IDictionary<string, object> tokenParams = new ConcurrentDictionary<string, object>();
            tokenParams.Add("client_id", ClientId);
            tokenParams.Add("client_secret", ClientSecret);
            tokenParams.Add("authorize_type", "silent");
            tokenParams.Add("grant_id", _grantId);
            var defaultHttpClient = new DefaultHttpClient();
            var result = defaultHttpClient.Send(ApiConst.TOKEN_URL, tokenParams, null, null);
            var oAuthToken = JsonConvert.DeserializeObject<OauthToken>(result);
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
            if (YouZanConfig.SaveAccessTokenToDB) return tokenData;
            if (Cache.Contains(_cacheKey))
                Cache.Remove(_cacheKey);
            Cache.Add(_cacheKey, tokenData, tokenData.ExpiresTime.AddMinutes(-5));

            return tokenData;
        }

        internal TokenData GetNewTokenData(bool create = true)
        {
            var token = GetNewTokenData();
            Task.Run(() =>
            {
                var yzToken = new YouZanAccessToken
                {
                    Key = _cacheKey,
                    TokenData = JsonConvert.SerializeObject(token),
                    AddTime = DateTime.Now,
                    UpdateTime = null
                };
                yzToken.Save(create);
            });
            return token;
        }
    }
}



