using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response
{
    public class YouZanResponse
    {
        /// <summary>
        /// 成功失败码
        /// 200 表示成功
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// 成功错误消息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 是否成功
        /// true表示成功
        /// false表示失败
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 错误响应
        /// </summary>
        [JsonProperty("gw_err_resp")]
        public ErrorResponse ErrorResponse { get; set; }
        
        /// <summary>
        /// 分页
        /// </summary>
        [JsonProperty("paginator")]
        public Paginator Paginator { get; set; }
    }

    /// <summary>
    /// API响应参数
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class YouZanResponse<T> : YouZanResponse
    {
        /// <summary>
        /// 响应数据
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; set; }

        /// <summary>
        /// 响应数据
        /// </summary>
        [JsonProperty("response")]
        public T Response { get; set; }
        
        /// <summary>
        /// 列表
        /// </summary>
        [JsonProperty("items")]
        public List<T> DataList { get; set; }
    }

    public class ErrorResponse
    {
        [JsonProperty("err_msg")]
        public string ErrorMessage { get; set; }
        [JsonProperty("err_code")]
        public int ErrorCode { get; set; }
    }

    /// <summary>
    /// 分页
    /// </summary>
    public class Paginator
    {
        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }
    }
}
