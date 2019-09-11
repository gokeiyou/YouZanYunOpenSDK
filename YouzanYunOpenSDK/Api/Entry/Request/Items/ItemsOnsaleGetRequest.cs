using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Items
{
    public class ItemsOnsaleGetRequest : YouZanRequest
    {

        /// <summary>
        /// 搜索字段，搜索商品名称
        /// </summary>
        [ApiField("q")]
        public string Query { get; set; }

        /// <summary>
        /// 商品分组Id，通过youzan.itemcategories.tags.get接口获取商品Id进行筛选
        /// </summary>
        [ApiField("tag_id")]
        public long TagId { get; set; }

        /// <summary>
        /// 排序方式，格式为column:asc/desc
        /// 目前排序字段：
        /// 1—创建时间：created_time
        /// 2—更新时间：update_time
        /// 3—价格：price
        /// 4—销量：sold_num
        /// </summary>
        [ApiField("order_by")]
        public string OrderBy { get; set; }

        /// <summary>
        /// 页码，不传或为0时默认设置为1
        /// </summary>
        [ApiField("page_no")]
        public int PageNo { get; set; }

        /// <summary>
        /// 更新时间起始，Unix时间戳请求 时间单位:ms 
        /// </summary>
        [ApiField("update_time_start")]
        public long UpdateTimeStart { get; set; }

        /// <summary>
        /// 每页条数，最大300个，不传或为0时默认设置为20
        /// </summary>
        [ApiField("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// 更新时间止，Unix时间戳请求 时间单位:ms
        /// </summary>
        [ApiField("update_time_end")]
        public long UpdateTimeEnd { get; set; }

    }
}
