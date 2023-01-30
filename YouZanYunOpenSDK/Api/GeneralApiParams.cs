using System.Collections.Generic;

namespace YouZan.Open.Api
{
    public class GeneralApiParams : IApiParams
    {
        private IDictionary<string, object> _apiParams = new Dictionary<string, object>();

        IDictionary<string, object> IApiParams.ToParams()
        {
            return _apiParams;
        }

        public void AddParam(IDictionary<string, object> apiParams)
        {
            _apiParams = apiParams;
        }

        public void AddParam(string name, object value)
        {
            _apiParams.Add(name, value);
        }
    }
}
