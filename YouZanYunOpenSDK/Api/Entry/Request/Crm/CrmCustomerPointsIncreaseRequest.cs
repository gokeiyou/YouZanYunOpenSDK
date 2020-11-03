using System.Collections.Generic;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Crm
{
    public class CrmCustomerPointsIncreaseRequest:YouZanRequest
    {
        [ApiField("params")]
        public Params Params { get; set; }
    }

    public class Params
    {
        /// <summary>
        /// 积分变动原因
        /// </summary>
        [ApiField("reason")]
        public string reason { get; set; }

        /// <summary>
        /// 业务唯一标示
        /// </summary>
        [ApiField("biz_value")]
        public string biz_value { get; set; }

        /// <summary>
        /// 积分变动值
        /// </summary>
        [ApiField("points")]
        public int points { get; set; }

        [ApiField("user")]
        public User user { get; set; }
        
    }

    public class User
    {
        /// <summary>
        /// 帐号类型（支持的用户账号类型
        /// 1-有赞粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id);
        /// 2-手机号;
        /// 3-三方帐号(原open_user_id:三方App用户ID，该参数仅限购买App开店插件的商家使用);
        /// 5-有赞用户id，用户在有赞的唯一id。推荐使用）
        /// </summary>
        [ApiField("account_type")]
        public int account_type { get; set; }

        /// <summary>
        /// 帐号ID
        /// </summary>
        [ApiField("account_id")]
        public string account_id { get; set; }
    }
}