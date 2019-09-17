using System;
using System.Collections.Generic;

namespace YouZan.Open.Api
{
    public class GeneralApiParams : IApiParams
    {
        private IDictionary<string, object> _ApiParams = new Dictionary<string, object>();

        IDictionary<string, object> IApiParams.ToParams()
        {
            return _ApiParams;
        }

        public void AddParam(IDictionary<string, object> apiParams)
        {
            this._ApiParams = apiParams;
        }

        public void AddParam(string name, object value)
        {
            _ApiParams.Add(name, value);
        }
    }
}
