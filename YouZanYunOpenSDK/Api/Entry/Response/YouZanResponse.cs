using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response
{
    /// <summary>
    /// API响应参数
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class YouZanResponse<T>
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
        /// 错误响应
        /// </summary>
        [JsonProperty("gw_err_resp")]
        public ErrorResponse ErrorResponse { get; set; }
    }

    public class ErrorResponse
    {
        [JsonProperty("err_msg")]
        public string ErrorMessage { get; set; }
        [JsonProperty("err_code")]
        public int ErrorCode { get; set; }
    }
}
