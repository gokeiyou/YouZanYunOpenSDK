using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 冻结&消费用户积分 请求参数
    /// </summary>
    public class CustomerPointsOperateIncreaseWithExpireRequest : YouZanRequest
    {
        /// <summary>
        /// 用户
        /// </summary>
        [ApiField("user")]
        public CustomerPointsOperateUser User { get; set; }
        /// <summary>
        /// 积分变动描述
        /// </summary>
        [ApiField("description")]
        public string Description { get; set; }
        /// <summary>
        /// 业务唯一标示，如订单号
        /// </summary>
        [ApiField("biz_value")]
        public string BizValue { get; set; }
        /// <summary>
        /// 校验客户是否存在
        /// </summary>
        [ApiField("check_customer")]
        public bool CheckCustomer { get; set; }
        /// <summary>
        /// 积分变动类别; 99: "开放平台操作加积分"
        /// </summary>
        [ApiField("event_type")]
        public int EventType { get; set; } = 99;
        /// <summary>
        /// 冻结&消费积分值
        /// </summary>
        [ApiField("points")]
        public int Points { get; set; }
        /// <summary>
        /// 是否发送微信通知
        /// </summary>
        [ApiField("send_message")]
        public bool SendMessage { get; set; }
        /// <summary>
        /// 是否需要走扩展点，默认：true(false走内部逻辑)
        /// </summary>
        [ApiField("is_do_ext_point")]
        public bool IsDoExtPoint { get; set; }
        /// <summary>
        /// 业务二级唯一标示，如时间戳,bizvalue+biztoken共同决定唯一一次操作
        /// </summary>
        [ApiField("biz_token")]
        public string BizToken { get; set; }
        /// <summary>
        /// 过期时间(必须大于当前时间,且精度为天,比如:2021-01-01 10:10:10,会当 2021-01-01 00:00:00处理)
        /// </summary>
        [ApiField("expired_at")]
        public DateTime ExpiredTime { get; set; }
    }

    public class CustomerPointsOperateUser
    {
        /// <summary>
        /// 操作人名字，可选字段
        /// </summary>
        [ApiField("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 帐号类型;支持的用户账号类型
        /// 1-有赞粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id) ; 
        /// 2-手机号;
        /// 3-三方帐号(原open_user_id:三方App用户ID，该参数仅限购买App开店插件的商家使用) ;
        /// 5-有赞用户id，用户在有赞的唯一id。推荐使用）
        /// </summary>
        [ApiField("account_type")]
        public int AccountType { get; set; }

        /// <summary>
        /// 帐号ID
        /// </summary>
        [ApiField("operator_name")]
        public string AccountId { get; set; }
    }
}
