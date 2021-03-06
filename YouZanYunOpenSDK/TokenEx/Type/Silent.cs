﻿using System;
using System.Collections.Generic;
using YouZan.Open.Http;
using Newtonsoft.Json;
using static YouZan.Open.TokenEx.OauthToken;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using YouZan.Open.Core;

namespace YouZan.Open.TokenEx
{
    public class Silent : AbstractOauth
    {
        private string _GrantId;

        private string _CacheKey = null;

        public Silent(string clientId, string clientSecret, string grantId) : base(clientId, clientSecret)
        {
            this._GrantId = grantId;
            _CacheKey = $"{clientId}_{grantId}";
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
                if (YouZanConfig.SaveAccessTokenToDB)
                {
                    tokenData = YouZanAccessToken.GetData(this._CacheKey, this.GetNewTokenData);
                }
                else
                    tokenData = cache.GetT(this._CacheKey, this.GetNewTokenData);
            }


            return tokenData;
        }

        internal TokenData GetNewTokenData()
        {
            TokenData tokenData = null;
            IDictionary<string, object> tokenParams = new ConcurrentDictionary<string, object>();
            tokenParams.Add("client_id", _ClientId);
            tokenParams.Add("client_secret", _ClientSecret);
            tokenParams.Add("authorize_type", "silent");
            tokenParams.Add("grant_id", _GrantId);
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
            if (!YouZanConfig.SaveAccessTokenToDB) {
                if (cache.Contains(this._CacheKey))
                    cache.Remove(this._CacheKey);
                cache.Add(this._CacheKey, tokenData, tokenData.ExpiresTime.AddMinutes(-5));
            }

            return tokenData;
        }

        internal TokenData GetNewTokenData(bool create = true)
        {
            var token = this.GetNewTokenData();
            Task.Run(() =>
            {
                var yzToken = new YouZanAccessToken
                {
                    Key = this._CacheKey,
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



