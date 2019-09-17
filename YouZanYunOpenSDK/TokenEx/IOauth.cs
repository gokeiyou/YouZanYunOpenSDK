using System;
using static YouZan.Open.TokenEx.OauthToken;

namespace YouZan.Open.TokenEx
{
    public interface IOauth
    {
        TokenData GetToken(bool getNew = false);
    }
}
