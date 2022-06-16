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
}
