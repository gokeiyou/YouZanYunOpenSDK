using System;
using YouZan.Open.Common.Constant;

namespace YouZan.Open.Auth
{
    public interface IAuth
    {
        OAuthEnum GetType();
    }
}
