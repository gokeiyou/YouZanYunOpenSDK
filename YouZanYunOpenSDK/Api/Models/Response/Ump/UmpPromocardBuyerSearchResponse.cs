using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Ump
{
    /// <summary>
    /// 查询买家优惠券列表
    /// </summary>
    public class UmpPromocardBuyerSearchResponse
    {
        /// <summary>
        /// 店铺在有赞的id标识，有赞平台生成，在有赞平台唯一，用于判断信息属于哪一个店铺
        /// </summary>
        [JsonProperty("kdt_id")]
        public string KdtId { get; set; }
        /// <summary>
        /// 领取时间（Unix时间戳，单位：毫秒）
        /// </summary>
        [JsonProperty("take_at")]
        public string TakeAt { get; set; }
        /// <summary>
        /// 优惠券使用时间，Unix时间戳，单位：毫秒
        /// </summary>
        [JsonProperty("used_at")]
        public string UsedAt { get; set; }
        /// <summary>
        /// 用券订单列表
        /// </summary>
        [JsonProperty("used_in_order_nos")]
        public List<string> UsedInOrderNos { get; set; }
        /// <summary>
        /// 优惠属性，1：金额（满减券或随机金额券）；2：折扣（折扣券）；3：兑换（兑换券）
        /// </summary>
        [JsonProperty("preferential_type")]
        public string PreferentialType { get; set; }
        /// <summary>
        /// 优惠卷使用门槛，订单满x元，单位：分，无使用门槛返回为0
        /// </summary>
        /// <example>1000</example>
        [JsonProperty("threshold_amount")]
        public long ThresholdAmount { get; set; }
        /// <summary>
        /// 面额（单位：分）
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
        /// <summary>
        /// 领取到的折扣值范围是1~99或0 ~100需要（例：88，8.8折）
        /// </summary>
        [JsonProperty("discount")]
        public int Discount { get; set; }
        /// <summary>
        /// 买家端优惠券/码核销码，即买家在店铺个人中心看到的优惠券/码对应的核销码值，可用youzan.ump.coupon.consume.verify接口进行核销
        /// </summary>
        [JsonProperty("verify_code")]
        public string VerifyCode { get; set; }
        /// <summary>
        /// 用于订单号（有赞订单号，E开头+年月日时分秒+随机数，长度24位字母和数字组合）
        /// </summary>
        [JsonProperty("used_in_order_no")]
        public string UsedInOrderNo { get; set; }
        /// <summary>
        /// 领取来源("none", "非法渠道"),("coupon_sending", "定向发券"),("apps_cards", "刮刮卡"),("apps_checkin", "签到"),("apps_guess", "疯狂猜猜猜"),("apps_shake", "摇一摇"),("apps_vote", "投票调查"),("apps_wheel", "大转盘"), ("apps_zodiac", "生肖翻翻看"), ("apps_visit_gift", "进店有礼"), ("scrm_card", "会员卡"), ("carmen", "有赞云接口"), （"meetreduce", "满减送"), ("poinsstore", "积分商城兑换"), ("wap_fetch", "普通领取"), ("wap_showcase", "微页面"), ("scrm_prepaid", "会员储值发卡"), ("fission", "裂变优惠券"), ("yz_anniversary", "有赞周年庆"), ("yz_meeting", "有赞会议"), ("divide_coupon", "瓜分券"), ("spotlight_platform", "有赞精选"), ("apps_help_cut", "砍价"), ("cim_interest", "兴趣人群"), ("mini_program", "小程序领取"), ("mini_program_11", "有赞精选双11小程序"), ("thirdparty", "三方券"), ("all", "通用券");
        /// </summary>
        [JsonProperty("receive_source")]
        public string ReceiveSource { get; set; }
        /// <summary>
        /// 优惠券过期时间，Unix时间戳，单位：毫秒
        /// </summary>
        [JsonProperty("expire_at")]
        public string ExpireAt { get; set; }
        /// <summary>
        /// 是否已使用，1：是；0：否
        /// </summary>
        [JsonProperty("is_used")]
        public short IsUsed { get; set; }
        /// <summary>
        /// 买家优惠券id，即买家在店铺个人中心看到的优惠券对应的id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// 卖家优惠券id，即卖家在店铺后台看到的优惠券对应的id
        /// </summary>
        [JsonProperty("coupon_group_id")]
        public long CouponGroupId { get; set; }
        /// <summary>
        /// 优惠卷标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// 实际优惠金额（单位：分）
        /// </summary>
        [JsonProperty("used_value")]
        public long UsedValue { get; set; }
        /// <summary>
        /// 是否同步微信支付商家券
        /// </summary>
        [JsonProperty("is_sync_wechat_paymch")]
        public bool IsSyncWechatPaymch { get; set; }
        /// <summary>
        /// 是否已同步卡包1-已同步，2-已删除
        /// </summary>
        [JsonProperty("is_sync_card")]
        public short IsSyncCard { get; set; }
        /// <summary>
        /// 优惠开始时间（Unix时间戳，单位：毫秒）
        /// </summary>
        [JsonProperty("valid_start_at")]
        public string ValidStartAt { get; set; }
    }
}
