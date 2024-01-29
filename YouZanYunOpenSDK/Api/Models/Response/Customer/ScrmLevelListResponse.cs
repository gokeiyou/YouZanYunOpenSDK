using System.Collections.Generic;
using Newtonsoft.Json;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Models.Response.Customer
{
    /// <summary>
    /// 获取该商家的会员等级模版列表 响应参数
    /// </summary>
    public class ScrmLevelListResponse
    {
        /// <summary>
        /// 等级列表
        /// </summary>
        [JsonProperty("level_details")]
        public List<LevelDetailModel> LevelDetails { get; set; }
    }

    /// <summary>
    /// 会员等级信息
    /// </summary>
    public class LevelDetailModel
    {
        /// <summary>
        /// 等级名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 权益实体(支持通用权益配置)
        /// </summary>
        [JsonProperty("level_benefit")]
        public LevelBenefitModel LevelBenefit { get; set; }

        /// <summary>
        /// 成长值会员的成长值门槛
        /// </summary>
        [JsonProperty("min_growth")]
        public long MinGrowth { get; set; }

        /// <summary>
        /// 生效方式模式:1-永久有效，2-从领取开始，持续一段时长
        /// </summary>
        [JsonProperty("term_type")]
        public int TermType { get; set; }

        /// <summary>
        /// 等级值
        /// </summary>
        [JsonProperty("level_value")]
        public int LevelValue { get; set; }

        /// <summary>
        /// 等级别名
        /// </summary>
        [JsonProperty("level_alias")]
        public string LevelAlias { get; set; }

        /// <summary>
        /// 生效持续天数,termType=2时，改值有效
        /// </summary>
        [JsonProperty("term_days")]
        public int TermDays { get; set; }

        /// <summary>
        /// 付费等级商品信息
        /// </summary>
        [JsonProperty("level_item_info")]
        public LevelItemInfoModel LevelItemInfo { get; set; }

        /// <summary>
        /// 是否启用；true-启用,false-禁用
        /// </summary>
        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 等级类型：1.免费类型2.付费类型
        /// </summary>
        [JsonProperty("level_type")]
        public int LevelType { get; set; }
    }

    /// <summary>
    /// 权益实体(支持通用权益配置)
    /// </summary>
    public class LevelBenefitModel
    {
        /// <summary>
        /// 包邮权益
        /// </summary>
        [JsonProperty("postage")]
        public LevelBenefitPostageModel LevelBenefitPostage { get; set; }

        /// <summary>
        /// 优惠券权益
        /// </summary>
        [JsonProperty("coupon")]
        public LevelBenefitCouponModel Coupon { get; set; }

        /// <summary>
        /// 积分回报率
        /// </summary>
        [JsonProperty("points_feedBack")]
        public LevelBenefitPointsFeedBackModel PointsFeedBack { get; set; }

        /// <summary>
        /// 积分权益
        /// </summary>
        [JsonProperty("points")]
        public LevelBenefitPointsModel Points { get; set; }

        /// <summary>
        /// 折扣权益
        /// </summary>
        [JsonProperty("discount")]
        public LevelBenefitDiscountModel Discount { get; set; }

        /// <summary>
        /// 赠品
        /// </summary>
        [JsonProperty("present")]
        public Present Present { get; set; }
    }

    /// <summary>
    /// 包邮权益
    /// </summary>
    public class LevelBenefitPostageModel
    {
        /// <summary>
        /// 是否可用
        /// </summary>
        [JsonProperty("is_available")]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 是否免邮
        /// </summary>
        [JsonProperty("is_free")]
        public bool IsFree { get; set; }
    }

    /// <summary>
    /// 优惠券权益
    /// </summary>
    public class LevelBenefitCouponModel
    {
        /// <summary>
        /// 是否可用
        /// </summary>
        [JsonProperty("is_available")]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 优惠券映射
        /// </summary>
        [JsonProperty("coupon_map")]
        public Dictionary<long, int> CouponMap { get; set; }
    }

    /// <summary>
    /// 积分回报率
    /// </summary>
    public class LevelBenefitPointsFeedBackModel
    {
        /// <summary>
        /// 是否可用
        /// </summary>
        [JsonProperty("is_available")]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// 消费回馈积分的积分倍率
        /// </summary>
        [JsonProperty("rate")]
        public int PointsRate { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }
    }

    /// <summary>
    /// 积分权益
    /// </summary>
    public class LevelBenefitPointsModel
    {
        /// <summary>
        /// 是否可用
        /// </summary>
        [JsonProperty("is_available")]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 积分数量
        /// </summary>
        [JsonProperty("points")]
        public int Points { get; set; }
    }

    /// <summary>
    /// 折扣权益
    /// </summary>
    public class LevelBenefitDiscountModel
    {
        /// <summary>
        /// 是否可用
        /// </summary>
        [JsonProperty("is_available")]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// 折扣值(1-100,10表示打一折)
        /// </summary>
        [JsonProperty("discount")]
        public int DiscountValue { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }
    }

    /// <summary>
    /// 赠品
    /// </summary>
    public class Present
    {
        /// <summary>
        /// 赠品列表
        /// </summary>
        [JsonProperty("present_list")]
        public List<LevelBenefitPresentModel> PresentList { get; set; }
    }

    /// <summary>
    /// 赠品
    /// </summary>
    public class LevelBenefitPresentModel
    {
        /// <summary>
        /// 赠品数量
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; set; }

        /// <summary>
        /// 赠品ID
        /// </summary>
        [JsonProperty("present_id")]
        public long PresentId { get; set; }
    }

    /// <summary>
    /// 付费等级商品信息
    /// </summary>
    public class LevelItemInfoModel
    {
        /// <summary>
        /// SKU IDs
        /// </summary>
        [JsonProperty("sku_ids")]
        public List<long> SkuIds { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("item_id")]
        public long ItemId { get; set; }
    }
}