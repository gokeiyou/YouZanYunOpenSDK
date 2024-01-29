using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YouZan.Open.Api.Models.Request.Customer;

namespace YouZan.Open.Api.Models.Response.Customer
{
    /// <summary>
    /// 商家创建会员卡 响应参数
    /// </summary>
    public class ScrmCardCreateResponse
    {
        /// <summary>
        /// 发卡链接
        /// </summary>
        [JsonProperty("card_url")]
        public string CardUrl { get; set; }

        /// <summary>
        /// 规则卡等级（0，1，2，3....10一共10级）若微商城店铺已升级至新会员等级体系，此字段将不在支持，无需传入。 未升级至等级体系的店铺仍可使用该字段，当 card_type 为2时必填
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// 卡的类型;1:无门槛卡,2:规则卡
        /// </summary>
        [JsonProperty("card_type")]
        public short CardType { get; set; }

        /// <summary>
        /// 会员卡权益
        /// </summary>
        [JsonProperty("rights")]
        public List<RightDTO> Rights { get; set; }

        /// <summary>
        /// 生效开始时间，如："2017-03-07 00:00:00"
        /// </summary>
        [JsonProperty("term_start_time")]
        public string TermStartTime { get; set; }

        /// <summary>
        /// 规则卡发放状态
        /// </summary>
        [JsonProperty("grant_condition")]
        public GrantConditionDTO GrantCondition { get; set; }

        /// <summary>
        /// 商家会员卡的唯一标识
        /// </summary>
        [JsonProperty("card_alias")]
        public string CardAlias { get; set; }

        /// <summary>
        /// 卡背景颜色，范围选择：#55bd47, #10ad61, #35a4de, #3d78da, #9058cb,#de9c33, #ebac16, #f9861f, #f08500, #e75735,#d54036, #cf3e36
        /// </summary>
        [JsonProperty("color_code")]
        public string ColorCode { get; set; }

        /// <summary>
        /// 是否允许微信端分享；true-允许，false-不允许
        /// </summary>
        [JsonProperty("is_allow_share")]
        public bool IsAllowShare { get; set; }

        /// <summary>
        /// 激活方式，0:不需要激活；1:仅需手机激活；2:手机+填写资料
        /// </summary>
        [JsonProperty("activate_mode")]
        public int ActivateMode { get; set; }

        /// <summary>
        /// 该卡失效后，转变的会员卡别名，默认不转变
        /// </summary>
        [JsonProperty("term_to_card_alias")]
        public string TermToCardAlias { get; set; }

        /// <summary>
        /// 使用须知 满300减10
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 生效方式类型，1:从领取开始无期限；2:从固定时刻开始，到固定时刻结束； 3:从领取开始，持续一段时长(termDays)
        /// </summary>
        [JsonProperty("term_type")]
        public int TermType { get; set; }

        /// <summary>
        /// 会员卡状态，1：正常；2：已禁用；3：已删除
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// 生效结束时间，如："2017-03-08 00:00:00"
        /// </summary>
        [JsonProperty("term_end_time")]
        public string TermEndTime { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [JsonProperty("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 微信卡包的同步设置
        /// </summary>
        [JsonProperty("sync_weixin_mode")]
        public int SyncWeixinMode { get; set; }

        /// <summary>
        /// 生效持续天数
        /// </summary>
        [JsonProperty("term_days")]
        public int TermDays { get; set; }

        /// <summary>
        /// 会员卡名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 同步微信卡状态，1：不同步；2：审核中；3：通过；4：失败
        /// </summary>
        [JsonProperty("sync_weixin_status")]
        public int SyncWeixinStatus { get; set; }
    }
}