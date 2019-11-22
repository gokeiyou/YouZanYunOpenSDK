using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Ump
{
    public class UmpCouponSearchResponse
    {

        /// <summary>
        /// 优惠券/优惠码列表
        /// </summary>
        [JsonProperty("groups")]
        public List<UmpCouponInfo> Coupons { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    /// <summary>
    /// 优惠券/优惠码实体
    /// </summary>
    public class UmpCouponInfo
    {

        /// <summary>
        /// 面额随机值上限，不随机为0
        /// </summary>
        [JsonProperty("value_random_to")]
        public long ValueRandomTo { get; set; }

        /// <summary>
        ///  满额条件（即使用门槛中订单满多少元）单位：分
        /// </summary>
        [JsonProperty("condition")]
        public long Condition { get; set; }

        /// <summary>
        /// 使用范围值
        /// </summary>
        [JsonProperty("range_value")]
        public List<CouponRange> RangeValue { get; set; }

        /// <summary>
        /// 券或码链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 创建时间戳，单位：ms
        /// </summary>
        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [JsonProperty("kdt_id")]
        public long KdtId { get; set; }

        /// <summary>
        /// 优惠券类型
        /// 7：优惠券
        /// 9：优惠码-一卡一码
        /// 10：优惠码-通用码
        /// </summary>
        [JsonProperty("group_type")]
        public int GroupType { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        [JsonProperty("stock_qty")]
        public long StockQty { get; set; }

        /// <summary>
        /// 是否仅原价购买商品时可用
        /// 1：是
        /// 0：否
        /// </summary>
        [JsonProperty("is_forbid_preference")]
        public bool IsForbidPreference { get; set; }

        /// <summary>
        /// 到期是否提醒
        /// 1：是
        /// 0：否
        /// </summary>
        [JsonProperty("expire_notice")]
        public bool ExpireNotice { get; set; }

        /// <summary>
        /// 总发放量
        /// </summary>
        [JsonProperty("total_qty")]
        public long TotalQty { get; set; }

        /// <summary>
        /// 优惠使用时间类型
        /// 1：表示固定活动时间
        /// 2：表示延迟类型，几天后几天内有效
        /// </summary>
        [JsonProperty("date_type")]
        public int DateType { get; set; }

        /// <summary>
        /// 是否允许分享优惠券。0：否；1：是
        /// </summary>
        [JsonProperty("is_share")]
        public int IsShare { get; set; }

        /// <summary>
        /// 会员等级
        /// </summary>
        [JsonProperty("user_level")]
        public int UserLevel { get; set; }

        /// <summary>
        /// 从领券日期开始算起，延迟开始的天数(目前支持0和1，表示当日和次日)
        /// </summary>
        [JsonProperty("fixed_begin_term")]
        public int FixedBeginTerm { get; set; }

        /// <summary>
        /// 是否限制
        /// n：1个人限领n次(n<=10)
        /// 0：不限制
        /// </summary>
        [JsonProperty("is_limit")]
        public bool IsLimit { get; set; }

        /// <summary>
        /// 使用说明
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 总使用数
        /// </summary>
        [JsonProperty("total_used")]
        public long TotalUsed { get; set; }

        /// <summary>
        /// 优惠券名称
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 是否失效
        /// 0：未失效
        /// 1：已失效
        /// </summary>
        [JsonProperty("is_invalid")]
        public bool IsInvalid { get; set; }

        /// <summary>
        /// 粉丝领取总人数（去重）
        /// </summary>
        [JsonProperty("total_fans_taked")]
        public long TotalFansTaked { get; set; }

        /// <summary>
        /// 是否同步微信卡包
        /// 1：是
        /// 0：否
        /// </summary>
        [JsonProperty("is_sync_weixin")]
        public bool IsSyncWeixin { get; set; }

        /// <summary>
        /// 有效结束时间戳，单位：ms
        /// </summary>
        [JsonProperty("valid_end_time")]
        public long ValidEndTime { get; set; }

        /// <summary>
        /// 优惠活动ID
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 总领取数
        /// </summary>
        [JsonProperty("total_take")]
        public long TotalTake { get; set; }

        /// <summary>
        /// 使用范围类型
        /// part：部分商品可用
        /// all：全部商品可用
        /// </summary>
        [JsonProperty("range_type")]
        public string RangeType { get; set; }

        /// <summary>
        /// 从领券日期开始算起，固定延时N天开始
        /// </summary>
        [JsonProperty("fixed_term")]
        public int FixedTerm { get; set; }

        /// <summary>
        /// 有效开始时间戳，单位：ms
        /// </summary>
        [JsonProperty("valid_start_time")]
        public long ValidStartTime { get; set; }

        /// <summary>
        /// 面额（单位：分）
        /// </summary>
        [JsonProperty("denominations")]
        public long Denominations { get; set; }

        /// <summary>
        /// 优惠属性
        /// 1：优惠
        /// 2：折扣
        /// </summary>
        [JsonProperty("preferential_type")]
        public int PreferentialType { get; set; }

        /// <summary>
        /// 折扣（88，8.8折）
        /// </summary>
        [JsonProperty("discount")]
        public int Discount { get; set; }

        /// <summary>
        /// 更新时间戳，单位：ms
        /// </summary>
        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; }
    }

    public class CouponRange
    {
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }
        [JsonProperty("goods_type")]
        public int GoodsType { get; set; }
    }

}
