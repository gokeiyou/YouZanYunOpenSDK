using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Ump
{
    public class UmpPromocardBuyerSearchResponse
    {
        /// <summary>
        /// 用于订单号（有赞订单号，E开头+年月日时分秒+随机数，长度24位字母和数字组合）
        /// </summary>
        [JsonProperty("used_in_order_no")]
        public string UsedInOrderNo { get; set; }

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
        /// 优惠属性，1：金额（满减券或随机金额券）；2：折扣（折扣券）；3：兑换（兑换券）
        /// </summary>
        [JsonProperty("preferential_type")]
        public string PreferentialType { get; set; }

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
        /// 用券订单列表
        /// </summary>
        [JsonProperty("used_in_order_nos")]
        public List<string> UsedInOrderNos { get; set; }

        /// <summary>
        /// 面额（单位：分）
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }

        /// <summary>
        /// 卖家优惠券id，即卖家在店铺后台看到的优惠券对应的id
        /// </summary>
        [JsonProperty("coupon_group_id")]
        public long CouponGroupId { get; set; }

        /// <summary>
        /// 实际优惠金额（单位：分）
        /// </summary>
        [JsonProperty("used_value")]
        public long UsedValue { get; set; }

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


    public class PromocardBuyerSearchModel
    {
        /// <summary>
        /// 用于订单号（有赞订单号，E开头+年月日时分秒+随机数，长度24位字母和数字组合）
        /// </summary>
        [JsonProperty("used_in_order_no")]
        public string UsedInOrderNo { get; set; }

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
        /// 优惠属性，1：金额（满减券或随机金额券）；2：折扣（折扣券）；3：兑换（兑换券）
        /// </summary>
        [JsonProperty("preferential_type")]
        public string PreferentialType { get; set; }

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
        /// 用券订单列表
        /// </summary>
        [JsonProperty("used_in_order_nos")]
        public List<string> UsedInOrderNos { get; set; }

        /// <summary>
        /// 面额（单位：分）
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }

        /// <summary>
        /// 卖家优惠券id，即卖家在店铺后台看到的优惠券对应的id
        /// </summary>
        [JsonProperty("coupon_group_id")]
        public long CouponGroupId { get; set; }

        /// <summary>
        /// 实际优惠金额（单位：分）
        /// </summary>
        [JsonProperty("used_value")]
        public long UsedValue { get; set; }

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
        /// 是否已同步卡包1-已同步，2-已删除
        /// </summary>
        [JsonProperty("is_sync_card")]
        public short IsSyncCard { get; set; }

        /// <summary>
        /// 优惠开始时间（Unix时间戳，单位：毫秒）
        /// </summary>
        [JsonProperty("valid_start_at")]
        public short ValidStartAt { get; set; }
    }
}
