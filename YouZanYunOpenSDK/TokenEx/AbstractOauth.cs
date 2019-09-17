using System;
using YouZan.Open.Cache;
using YouZan.Open.Utils;
using static YouZan.Open.TokenEx.OauthToken;

namespace YouZan.Open.TokenEx
{
    public abstract class AbstractOauth : IOauth
    {
        private  string _TokenUrl = "https://open.youzanyun.com/auth/token";

        protected string _ClientId;

        protected string _ClientSecret;

        protected YouZanCache cache = new YouZanCache();

        protected AbstractOauth(string clientId, string clientSecret)
        {
            CheckUtils.CheckParams(clientId, clientSecret);
            this._ClientId = clientId;
            this._ClientSecret = clientSecret;
        }

        public void SetTokenUrl(string tokenUrl) {

            this._TokenUrl = tokenUrl;
        }


        public string GetTokenUrl()
        {
            return _TokenUrl;
        }

        public abstract TokenData GetToken(bool getNew = false);
    }
}
