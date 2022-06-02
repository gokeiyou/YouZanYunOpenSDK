using System;
using YouZan.Open.Common.Constant;

namespace YouZan.Open.Api
{
    public class GeneralApi : AbstractApi
    {
        /**
         * 请求方法
         */
        private string httpMethod;
        /**
         * 请求接口名
         * 
         */        
        private string serviceName;
        /// <summary>
        /// 客户端ID
        /// </summary>
        private string clientId;
        /// <summary>
        /// 店铺ID
        /// </summary>
        private string grantId;

        /***
         * 
         * 鉴权类型
         */         
        private OAuthEnum oAuthType;


        public override string GetGateway()
        {
            return this.Gateway;
        }

        public override string GetHttpMethod()
        {
            return this.httpMethod;
        }

        public override string GetName()
        {
            return this.serviceName;
        }

        public override OAuthEnum GetOAuthType()
        {
            return this.oAuthType;
        }

        public OAuthEnum SetOAuthType(OAuthEnum oAuthType)
        {
            return this.oAuthType = oAuthType;
        }

        public void SetHttpMethod(string httpMethod)
        {
            this.httpMethod = httpMethod;
        }

        public void SetName(string serviceName)
        {
            this.serviceName = serviceName;
        }

        public void SetVersion(string serviceVersion)
        {
            this.Version = serviceVersion;
        }

        public void SetClientId(string clientId)
        {
            this.clientId = clientId;
        }

        public override string GetClientId()
        {
            return this.clientId;
        }

        public void SetGrantId(string grantId)
        {
            this.grantId = grantId;
        }

        public override string GetGrantId()
        {
            return this.grantId;
        }

        public override string ToString()
        {
            return "GeneralApi{" +
                    "httpMethod='" + httpMethod + '\'' +
                    ", serviceName='" + serviceName + '\'' +
                    ", serviceVersion='" + Version + '\'' +
                    ", oAuthType=" + oAuthType +
                    ", apiParams=" + ApiParams +
                    ", gateway='" + Gateway + '\'' +
                    ", headers=" + Headers +
                    '}';
        }
    }
}
