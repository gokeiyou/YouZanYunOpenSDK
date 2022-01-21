using System.Collections.Generic;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    /// <summary>
    /// 生成微信小程序二维码参数
    /// </summary>
    /// <see cref="https://doc.youzanyun.com/detail/API/0/910"/>
    public class UsersChannelCodeUltraGetRequest : YouZanRequest
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [ApiField("params")]
        public UsersChannelCodeUltraGetParam Params { get; set; }
    }

    /// <summary>
    /// 生成微信小程序二维码 请求参数实体
    /// </summary>
    public class UsersChannelCodeUltraGetParam
    {
        /// <summary>
        /// 是否使用透明底色
        /// </summary>
        /// <example>false</example>
        [ApiField("hya_line")]
        public bool hya_line { get; set; }
        /// <summary>
        /// 二维码宽度默认400px,业务方可自行设置,
        /// </summary>
        /// <example>500</example>
        [ApiField("width")]
        public int width { get; set; }
        /// <summary>
        /// 店铺ID
        /// </summary>
        /// <example>63077</example>
        [ApiField("kdt_id")]
        public long kdt_id { get; set; }
        /// <summary>
        /// 固定值，只能写“pages/common/blank-page/index”
        /// </summary>
        /// <example>“pages/common/blank-page/index”</example>
        [ApiField("page")]
        public string page => "\"pages/common/blank-page/index\"";
        /// <summary>
        /// 自定义参数，params参数中必须包含kdtId、guestKdtId、page这三个字段；单店情况下kdtId和guestKdtId保持一致；连锁模式下guestKdtId连锁用当前访问的店铺ID；page参数为真实需要的小程序落地页路径。sls和dcPs保留参数使用默认即可
        /// </summary>
        /// <example>{"kdtId"："63077"，"guestKdtId"："63077"，"price"："0.50"，"offlineId"：""，"alias"："26z0lkunijz2d"，"page"："包/好的细节/索引"，"原始价格"："1元"，"sls"：""，"dcPs"："}</example>
        [ApiField("params")]
        public Dictionary<string, string> Params { get; set; }
    }
}
