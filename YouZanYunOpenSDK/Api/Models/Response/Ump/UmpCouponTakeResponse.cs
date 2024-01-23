using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Ump
{
    public class UmpCouponTakeResponse
    {

        [JsonProperty("promocard")]
        public PromoCard PromoCard { get; set; }

        [JsonProperty("promocode")]
        public PromoCode PromoCode { get; set; }

        [JsonProperty("coupon_type")]
        public string CouponType { get; set; }
    }

    public class PromoCard
    {

        /// <summary>
        /// 优惠券生效时间，时间戳
        /// 单位：ms
        /// </summary>
        [JsonProperty("start_at")]
        public long StartTime { get; set; }

        /// <summary>
        /// 优惠券是否已使用
        /// 0：未使用
        /// 1 ：已使用
        /// </summary>
        [JsonProperty("is_used")]
        public bool IsUsed { get; set; }

        /// <summary>
        /// 优惠属性
        /// 1：优惠
        /// 2：折扣
        /// </summary>
        [JsonProperty("preferential_type")]
        public int PreferentialType { get; set; }

        /// <summary>
        /// 优惠券面额（单位：元）
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// 优惠券是否已失效
        /// 0：未失效
        /// 1：已失效
        /// </summary>
        [JsonProperty("is_invalid")]
        public bool IsInvalid { get; set; }

        /// <summary>
        /// 折扣（例88表示8.8折）
        /// </summary>
        [JsonProperty("discount")]
        public int Discount { get; set; }

        /// <summary>
        /// 优惠券详情链接
        /// </summary>
        [JsonProperty("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 优惠券 id
        /// </summary>
        [JsonProperty("promocard_id")]
        public long Id { get; set; }

        /// <summary>
        /// 优惠券满额条件
        /// </summary>
        [JsonProperty("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// 优惠券标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 优惠券背景颜色
        /// </summary>
        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// 优惠券过期时间，时间戳
        /// 单位：ms
        /// </summary>
        [JsonProperty("end_at")]
        public long EndTime { get; set; }

        /// <summary>
        /// 优惠券是否已过期
        /// 0：未过期
        /// 1：已过期
        /// </summary>
        [JsonProperty("is_expired")]
        public bool IsExpired { get; set; }

        /// <summary>
        /// 核销码
        /// </summary>
        [JsonProperty("verify_code")]
        public string VerifyCode { get; set; }

    }

    public class PromoCode
    {

        /// <summary>
        /// 核销码
        /// </summary>
        [JsonProperty("verify_code")]
        public string VerifyCode { get; set; }

        /// <summary>
        /// 优惠券生效时间，时间戳
        /// 单位：ms
        /// </summary>
        [JsonProperty("start_at")]
        public long StartTime { get; set; }

        /// <summary>
        /// 优惠券背景颜色
        /// </summary>
        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// 优惠券详情链接
        /// </summary>
        [JsonProperty("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 优惠券满额条件
        /// </summary>
        [JsonProperty("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// 优惠券是否已过期
        /// 0：未过期
        /// 1：已过期
        /// </summary>
        [JsonProperty("is_expired")]
        public bool IsExpired { get; set; }

        /// <summary>
        /// 优惠码编号
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 优惠券标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 优惠券面额（单位：元）
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// 优惠券是否已使用
        /// 0：未使用
        /// 1 ：已使用
        /// </summary>
        [JsonProperty("is_used")]
        public bool IsUsed { get; set; }

        /// <summary>
        /// 优惠券过期时间，时间戳
        /// 单位：ms
        /// </summary>
        [JsonProperty("end_at")]
        public long EndTime { get; set; }

        /// <summary>
        /// 优惠券是否已失效
        /// 0：未失效
        /// 1：已失效
        /// </summary>
        [JsonProperty("is_invalid")]
        public bool IsInvalid { get; set; }

        /// <summary>
        /// 优惠券 id
        /// </summary>
        [JsonProperty("promocode_id")]
        public long Id { get; set; }

    }
}
