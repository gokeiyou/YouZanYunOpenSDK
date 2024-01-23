using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    /// <summary>
    /// 根据微信粉丝用户的 weixin_openid 或 fans_id 绑定对应的标签 请求参数实体
    /// </summary>
    /// <see cref="https://doc.youzanyun.com/detail/API/0/103"/>
    public class UsersWeixinFollowerTagsAddRequest : YouZanRequest
    {
        /// <summary>
        /// 标签名，多个标签名用“,”分隔
        /// </summary>
        /// <example>测试</example>
        [ApiField("tags")]
        public string Tags { get; set; }
        /// <summary>
        /// 需要返回的除微信粉丝基础信息外的资产信息。枚举值：points，trade，level。points可获取“points”字段，trade可获取”traded_num,trade_money”两个字段，level可获取”level_info”字段信息。传多个枚举值需用“,”分隔，如果该字段为空则只返回粉丝基础信息。默认为空。(“fields”字段传入枚举值越多，查询数据耗费时间越长。）
        /// </summary>
        /// <example>points，trade</example>
        [ApiField("fields")]
        public string Fields { get; set; }
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
