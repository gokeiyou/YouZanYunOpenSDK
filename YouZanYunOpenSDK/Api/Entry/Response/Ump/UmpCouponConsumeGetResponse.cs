using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Ump
{
    public class UmpCouponConsumeGetResponse
    {
        [JsonProperty("coupon")]
        public Coupon CouponInfo { get; set; }

        /// <summary>
        /// 核销优惠券/码的时间，Unix时间戳，单位：毫秒
        /// 1570872202000
        /// </summary>
        [JsonProperty("consume_at")]
        public string ConsumeAt { get; set; }

        /// <summary>
        /// 优惠码号（一卡一码对应的优惠码号）
        /// 410503396715
        /// </summary>
        [JsonProperty("promocode")]
        public string Promocode { get; set; }

        /// <summary>
        /// 实际核销面额，单位：分
        /// 93
        /// </summary>
        [JsonProperty("used_value")]
        public string UsedValue { get; set; }

        /// <summary>
        /// 核销状态：0-未核销，1-已核销
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// 如果卡券已被独立核销，值为核销单单号；如果卡券在商城的交易中被核销，值为订单号
        /// M2019101217232283968
        /// </summary>
        [JsonProperty("consume_id")]
        public string ConsumeId { get; set; }

        /// <summary>
        /// 买家端优惠券/码核销码，即买家在店铺个人中心看到的优惠券/码对应的核销码值
        /// 044704668961
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 买家优惠券id，即买家在店铺个人中心看到的优惠券对应的id
        /// </summary>
        [JsonProperty("promocard_id")]
        public long PromocardId { get; set; }

        /// <summary>
        /// 买家优惠码id，即买家在店铺个人中心看到的优惠码对应的id
        /// </summary>
        [JsonProperty("promocode_id")]
        public long PromocodeId { get; set; }

    }

    public class Coupon
    {
        /// <summary>
        /// 领券延时类型：0-当天，1-次日（配合fixed_term使用）
        /// </summary>
        [JsonProperty("fixed_begin_term")]
        public int FixedBeginTerm { get; set; }

        /// <summary>
        /// 使用优惠的次数
        /// </summary>
        [JsonProperty("stat_use_num")]
        public int StatUseNum { get; set; }

        /// <summary>
        /// 会员等级名称，目前仅返回""，预留字段
        /// </summary>
        [JsonProperty("user_level_name")]
        public string UserLevelName { get; set; }

        /// <summary>
        /// 每人限领个数，为0则表示不限制
        /// </summary>
        [JsonProperty("quota")]
        public int Quota { get; set; }

        /// <summary>
        /// 剩余可用库存
        /// </summary>
        [JsonProperty("stock")]
        public int Stock { get; set; }

        /// <summary>
        /// 当fixed_begin_term = 0，表示从领券日当日起，N天内可用；当fixed_begin_term= 1，表示从领券次日起，N天后可使用
        /// </summary>
        [JsonProperty("fixed_term")]
        public int FixedTerm { get; set; }

        /// <summary>
        /// 是否可分享领取链接，：0-否，1-是
        /// </summary>
        [JsonProperty("is_share")]
        public int IsShare { get; set; }

        /// <summary>
        /// 优惠使用时间类型，1-固定活动时间，2-延迟类型，几天后几天内有效
        /// </summary>
        [JsonProperty("date_type")]
        public int DateType { get; set; }

        /// <summary>
        /// 优惠面额。单位：元，精确到分
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// 优惠活动状态：0-优惠活动有效，1-优惠活动失效（同步微信卡券失败后活动自动失效，商家可以在微商城后台手动设置失效），2-微信卡券审核中
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// 如果is_random为1，则该字段表示随机金额的上限。单位：元，精确到分
        /// </summary>
        [JsonProperty("value_random_to")]
        public string ValueRandomTo { get; set; }

        /// <summary>
        /// 优惠类型：1-优惠金额，对应value，2-优惠折扣，对应discount
        /// </summary>
        [JsonProperty("preferential_type")]
        public short PreferentialType { get; set; }

        /// <summary>
        /// 如果is_at_least为1，该字段表示订单必须满这个价格，优惠才可用。单位：元，精确到分
        /// </summary>
        [JsonProperty("at_least")]
        public string AtLeast { get; set; }

        /// <summary>
        /// 商品适用范围all：全部商品可用；part：部分商品可用；excluded：部分商品不可用
        /// </summary>
        [JsonProperty("range_type")]
        public string RangeType { get; set; }

        /// <summary>
        /// 会员等级id, 目前仅返回0，预留字段
        /// </summary>
        [JsonProperty("need_user_level")]
        public int NeedUserLevel { get; set; }

        /// <summary>
        /// 领取优惠的人数
        /// </summary>
        [JsonProperty("stat_fetch_user_num")]
        public int StatFetchUserNum { get; set; }

        /// <summary>
        /// 卖家创建一个优惠券/码活动时的活动id，coupon.group_id、activity_id、group_id都是优惠活动id（不是优惠券/码id）
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// 优惠活动的类型：优惠券-PROMOCARD、优惠码-PROMOCODE
        /// </summary>
        [JsonProperty("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 是否同步微信卡券：0 -否，1-是
        /// </summary>
        [JsonProperty("is_sync_weixin")]
        public string IsSyncWeixin { get; set; }

        /// <summary>
        /// 折扣（例：88，8.8折）
        /// </summary>
        [JsonProperty("discount")]
        public int Discount { get; set; }
        /// <summary>
        /// 总库存
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
        /// <summary>
        /// 是否到期提醒：1-是，0-否
        /// </summary>
        [JsonProperty("expire_notice")]
        public int ExpireNotice { get; set; }
        /// <summary>
        /// 微信卡券ID
        /// </summary>
        [JsonProperty("weixin_card_id")]
        public string WeixinCardId { get; set; }
        /// <summary>
        /// 使用说明
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 优惠券/码有效起始时间，Unix时间戳，单位：毫秒
        /// </summary>
        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        /// <summary>
        /// 是否仅原价购买商品时可用：0-不限制，1-不能与其他活动叠加使用
        /// </summary>
        [JsonProperty("is_forbid_preference")]
        public int IsForbidPreference { get; set; }

        /// <summary>
        /// 领取优惠的次数
        /// </summary>
        [JsonProperty("stat_fetch_num")]
        public int StatFetchNum { get; set; }
        /// <summary>
        /// 优惠券/码有效结束时间，Unix时间戳，单位：毫秒
        /// </summary>
        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        /// <summary>
        /// 优惠活动创建时间，Unix时间戳，单位：毫秒
        /// </summary>
        [JsonProperty("created")]
        public string Created { get; set; }
        /// <summary>
        /// 优惠活动创建时间，Unix时间戳，单位：毫秒
        /// </summary>
        [JsonProperty("title")]
        public string title { get; set; }

        /// <summary>
        /// 设置门槛（多少元可用）：0-表示不限制，1-表示限制
        /// </summary>
        [JsonProperty("is_at_least")]
        public int IsAtLeast { get; set; }

        /// <summary>
        /// 优惠领取链接
        /// </summary>
        [JsonProperty("fetch_url")]
        public string FetchUrl { get; set; }

        /// <summary>
        /// 优惠活动更新时间，Unix时间戳，单位：毫秒
        /// </summary>
        [JsonProperty("updated")]
        public string Updated { get; set; }

        /// <summary>
        /// 是否是随机优惠：0-不是随机优惠，1-是随机优惠
        /// </summary>
        [JsonProperty("is_random")]
        public short IsRandom { get; set; }

    }
}
