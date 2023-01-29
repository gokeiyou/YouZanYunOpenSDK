using System.Collections.Generic;
using YouZan.Open.Api.Constant;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    /// <summary>
    /// 用户查询接口请求参数实体
    /// </summary>
    public class UsersInfoQueryRequest : YouZanRequest
    {
        /// <summary>
        /// weixin_open_id类型，1-微信公众号，2-微信小程序，9-微信大账号，weixin_open_id不为空时该参数必填
        /// </summary>
        /// <example>1</example>
        [ApiField("open_id_type")]
        public WeiXinOpenIdType OpenIdType { get; set; }
        /// <summary>
        /// 微信体系的openId；和yz_open_id、mobile、weixin_union_id至少传一个
        /// </summary>
        /// <example>oHIuujqttsLcr9LxPfu4aKaEkNlcliq</example>
        [ApiField("weixin_open_id")]
        public string WeixinOpenId { get; set; }
        /// <summary>
        /// 手机号，只支持+86；和yz_open_id、weixin_union_id、weixin_open_id至少传一个
        /// </summary>
        /// <example>138****3622</example>
        [ApiField("mobile")]
        public string Mobile { get; set; }
        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id。推荐使用；和mobile、weixin_union_id、weixin_open_id至少传一个
        /// </summary>
        /// <example>LnhGm4rh576452722916618240</example>
        [ApiField("yz_open_id")]
        public string YzOpenId { get; set; }
        /// <summary>
        /// 微信体系的unionId；和yz_open_id、mobile、weixin_open_id至少传一个
        /// </summary>
        /// <example>oyzyK1Ma95qZtmRvUTFXqoNyQ3mUliq</example>
        [ApiField("weixin_union_id")]
        public string WeixinUnionId { get; set; }
        /// <summary>
        /// 返回结果类型列表，
        /// 0-手机帐号；
        /// 1-微信公众号；
        /// 2-微信小程序；
        /// 9-微信大账号；
        /// 默认0。
        /// 开发者可以根据自己需要的选择传入。
        /// 补充说明：；在微信公众号场景下，正常会进行两次授权，一次通过商家公众号授权，一次通过有赞公众号授权，分别产生不同的用户数据： 1）1-微信公众号：通过商家的公众号授权产生的用户 2）9-微信大账号：通过”有赞“公众号授权产生的用户
        /// </summary>
        /// <example>[0,1]</example>
        [ApiField("result_type_list")]
        public List<UsersInfoQueryResultType> ResultTypeList { get; set; } = new List<UsersInfoQueryResultType> { UsersInfoQueryResultType.Mobile };
    }
}
