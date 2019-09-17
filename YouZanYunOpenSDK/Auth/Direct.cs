using System;
using YouZan.Open.Common.Constant;

namespace YouZan.Open.Auth
{
    public class Direct : IAuth
    {
        public Direct() { }

        OAuthEnum IAuth.GetType()
        {
            return OAuthEnum.DIRECT;
        }
    }
}
