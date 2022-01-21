using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Users
{
    /// <summary>
    /// 生成微信小程序二维码（支持超过32可见字符的自定义参数）返回参数实体
    /// </summary>
    /// <see cref="https://doc.youzanyun.com/detail/API/0/910"/>
    public class UsersChannelCodeUltraGetResponse
    {
        /// <summary>
        /// 转义后的自定义参数
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }
        /// <summary>
        /// base64编码之后的二维码
        /// </summary>
        [JsonProperty("image_base64")]
        public string ImageBase64 { get; set; }
    }
}
