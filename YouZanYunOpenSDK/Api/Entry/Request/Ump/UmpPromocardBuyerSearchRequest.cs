using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Ump
{
    public class UmpPromocardBuyerSearchRequest :YouZanRequest
    {
        /// <summary>
        /// VALID 有效（未使用且未过期）;USED 已使用（已使用）;INVALID 已失效（已使用或者优惠券过期）
        /// </summary>
        [ApiField("status")]
        public string Status { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        [ApiField("mobile")]
        public string Mobile { get; set; }
        /// <summary>
        /// 三方App用户ID，该参数仅限购买App开店插件的商家使用
        /// </summary>
        [ApiField("open_user_id")]
        public string OpenUserId { get; set; }
        /// <summary>
        /// fans_type：1:代表微信自有粉丝；2：代表[微博平台]产生的粉丝；9：代表粉丝类型为微信大账号粉丝；188：代表[qq平台]产生的粉丝；736:代表[支付宝平台]产生的粉丝；1181:代表[今日头条]产生的粉丝；非上述fans_type其他：代表其他平台或小程序粉丝或者三方sdk产生的粉丝；
        /// </summary>
        [ApiField("fans_type")]
        public long FansType { get; set; }
        /// <summary>
        /// 有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id。fans_id和fans_type组成一个唯一的有赞用户标识。从浏览器过来的下单的是拿不到fans_id。 大账号fans_id：通过微信去访问有赞店铺的商品等，系统会给用户生成fansid。 用户自有fans_id（从三方过来的）：关注任意一个公众号(包括有赞大账号)后生成ID。
        /// </summary>
        [ApiField("fans_id")]
        public long FansId { get; set; }

    }
}
