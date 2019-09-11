using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Salesman
{
    public class SalesmanAccountUpdateResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }
}
