using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    /// <summary>
    /// 根据微信粉丝用户的 weixin_openid 或 fans_id 删除对应的标签参数
    /// </summary>
    public class UsersWeixinFollowerTagsDeleteRequest : YouZanRequest
    {
        /// <summary>
        /// 标签名，多个标签名用“,”分隔
        /// </summary>
        /// <example>测试,测试1</example>
        [ApiField("tags")]
        public string Tags { get; set; }
        /// <summary>
        /// 有赞yz_open_id
        /// </summary>
        /// <example>22323sdf-dfsdFFYmk68NpA-yI8</example>
        [ApiField("yz_open_id")]
        public string YzOpenId { get; set; }
        /// <summary>
        /// 微信粉丝用户的openid
        /// </summary>
        /// <example>omRVS5qtagCvi5NAXL8MF_lvmNr1</example>
        [ApiField("weixin_openid")]
        public string WeixinOpenId { get; set; }
        /// <summary>
        /// 微信粉丝用户ID。调用时，参数 weixin_openid 和 fans_id 选其一即可
        /// </summary>
        /// <example>1243449546</example>
        [ApiField("fans_id")]
        public string FansId { get; set; }
    }
}
