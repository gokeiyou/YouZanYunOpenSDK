using System;
using System.Collections.Generic;

namespace YouZan.Open.Api
{
    public interface IApiParams
    {
        IDictionary<string, object> ToParams();
    }
}
