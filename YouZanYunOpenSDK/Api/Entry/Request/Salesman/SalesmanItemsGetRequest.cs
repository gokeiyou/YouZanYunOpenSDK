using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Salesman
{
    public class SalesmanItemsGetRequest : YouZanRequest
    {
        /// <summary>
        /// 商品id列表，逗号分隔
        /// </summary>
        [ApiField("item_ids")]
        public string ItemIds { get; set; }

    }
}
