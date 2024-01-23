using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response
{
    /// <summary>
    /// 操作成功返回实体
    /// </summary>
    public class SuccessResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    /// <summary>
    /// 是否成功泛型实体
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SuccessResponse<T>
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonProperty("is_success")]
        public T IsSuccess { get; set; }
    }

    public class PageResponse<T>
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }
        /// <summary>
        /// 每页的最大记录条数
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 列表
        /// </summary>
        [JsonProperty("items")]
        public List<T> Items { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
