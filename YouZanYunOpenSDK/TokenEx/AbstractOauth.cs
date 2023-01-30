using System;
using YouZan.Open.Cache;
using YouZan.Open.Utils;
using static YouZan.Open.TokenEx.OauthToken;

namespace YouZan.Open.TokenEx
{
    public abstract class AbstractOauth : IOauth
    {
        protected readonly string ClientId;

        protected readonly string ClientSecret;

        protected readonly YouZanCache Cache = new YouZanCache();

        protected AbstractOauth(string clientId, string clientSecret)
        {
            CheckUtils.CheckParams(clientId, clientSecret);
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        public abstract TokenData GetToken(bool getNew = false);
    }
}
