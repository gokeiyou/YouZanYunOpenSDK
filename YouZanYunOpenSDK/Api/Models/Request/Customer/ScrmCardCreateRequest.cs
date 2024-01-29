using System.Collections.Generic;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Models.Request.Customer
{
    /// <summary>
    /// 商家创建会员卡 请求参数
    /// </summary>
    public class ScrmCardCreateRequest : YouZanRequest
    {
        // 帮我写一个属性，使用驼峰命名，带XML注释：111，ApiField特性：card_create
        [ApiField("card_create")] public ScrmCardCreateDTO CardCreate { get; set; }
    }

    /// <summary>
    /// 会员卡信息
    /// </summary>
    public class ScrmCardCreateDTO
    {
        /// <summary>
        /// 规则卡发放条件
        /// </summary>
        [ApiField("grant_condition")]
        public GrantConditionDTO GrantCondition { get; set; }

        /// <summary>
        /// 激活方式;0-无需条件，自动激活,1-手机号码激活,2-手机号码 + 资料 激活，默认为空
        /// </summary>
        [ApiField("activate_mode")]
        public int ActivateMode { get; set; }

        /// <summary>
        /// 会员卡权益
        /// </summary>
        [ApiField("rights")]
        public List<ScrmCardRightDTO> Rights { get; set; }

        /// <summary>
        /// 该卡失效后，转变的会员卡别名，默认不转变
        /// </summary>
        [ApiField("term_to_card_alias")]
        public string TermToCardAlias { get; set; }

        /// <summary>
        /// 会员卡名，卡名不允许重复，最大字符：9
        /// </summary>
        [ApiField("name")]
        public string Name { get; set; }

        /// <summary>
        /// 生效结束时间，如："2017-03-08 00:00:00"。term_type为2时必传
        /// </summary>
        [ApiField("term_end_time")]
        public string TermEndTime { get; set; }

        /// <summary>
        /// 生效方式类型，1:从领取开始无期限；2:从固定时刻开始，到固定时刻结束；3:从领取开始，持续一段时长(termDays)
        /// </summary>
        [ApiField("term_type")]
        public int TermType { get; set; }

        /// <summary>
        /// 卡的类型;1:无门槛卡,2:规则卡
        /// </summary>
        [ApiField("card_type")]
        public int CardType { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [ApiField("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 生效开始时间，如："2017-03-07 00:00:00"，term_type为2时必传
        /// </summary>
        [ApiField("term_start_time")]
        public string TermStartTime { get; set; }

        /// <summary>
        /// 卡背景颜色，范围选择：#55bd47, #10ad61, #35a4de, #3d78da, #9058cb,#de9c33, #ebac16, #f9861f, #f08500, #e75735,#d54036, #cf3e36
        /// </summary>
        [ApiField("color_code")]
        public string ColorCode { get; set; }

        /// <summary>
        /// 使用须知(长度限制800个字符)
        /// </summary>
        [ApiField("description")]
        public string Description { get; set; }

        /// <summary>
        /// 是否允许微信端分享；true-允许，false-不允许
        /// </summary>
        [ApiField("is_allow_share")]
        public bool IsAllowShare { get; set; }

        /// <summary>
        /// 生效持续天数，term_type为3时必传
        /// </summary>
        [ApiField("term_days")]
        public int TermDays { get; set; }

        /// <summary>
        /// 微信卡包的同步设置范围选择：0-3，0:不同步；1:基于卡号核销；2:基于卡号和条形码核销；3:基于卡号和二维码核销，默认为空
        /// </summary>
        [ApiField("sync_weixin_mode")]
        public int SyncWeixinMode { get; set; }

        /// <summary>
        /// 规则卡等级
        /// </summary>
        [ApiField("level")]
        public int Level { get; set; }
    }

    public class ScrmCardRightDTO
    {
        /// <summary>
        /// 权益的名称
        /// </summary>
        [ApiField("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优惠券权益列表
        /// </summary>
        [ApiField("coupon")]
        public List<CouponDTO> Coupon { get; set; }

        /// <summary>
        /// 销售员返佣
        /// </summary>
        [ApiField("salesman")]
        public SalesmanDTO Salesman { get; set; }

        /// <summary>
        /// 大客户定制权益
        /// </summary>
        [ApiField("custom")]
        public CustomDTO Custom { get; set; }

        /// <summary>
        /// 是否可用，必须为true
        /// </summary>
        [ApiField("is_available")]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// 权益类型，1:包邮；2:折扣；3:送现金券；4：送积分
        /// </summary>
        [ApiField("type")]
        public int Type { get; set; }

        /// <summary>
        /// 积分权益字段，积分数量（type为4时必传）
        /// </summary>
        [ApiField("points")]
        public int Points { get; set; }

        /// <summary>
        /// 折扣权益字段，折数 ，1表示0.01折范围选择：1-100（type为2时必传）
        /// </summary>
        [ApiField("discount")]
        public int Discount { get; set; }
    }
}