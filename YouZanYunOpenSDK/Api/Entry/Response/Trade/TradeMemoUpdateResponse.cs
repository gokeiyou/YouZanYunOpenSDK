using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Trade
{
    public class TradeMemoUpdateResponse
    {

        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }

    }
}
