using System;
using System.Collections.Generic;
using YouZan.Open.Api;
using YouZan.Open.Auth;
using YouZan.Open.Common.Constant;
using YouZan.Open.TokenEx;

namespace YouZan.Open.Core
{
    public interface IYouZanClient
    {
        string Invoke(GeneralApi api, IAuth auth, IDictionary<string, string> headers, List<KeyValuePair<string, string>> files);

    }
}
