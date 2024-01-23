using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 权益卡购卡记录 返回实体
    /// </summary>
    public class ScrmCustomerGetRecordResponse
    {
        /// <summary>
        /// 会员卡续费日志
        /// </summary>
        [JsonProperty("customer_card_buy_log")]
        public CustomerCardBuyLog CustomerCardBuyLog { get; set; }
        /// <summary>
        /// 领取时间(如果是需要激活卡则为激活时间)，单位：毫秒
        /// </summary>
        /// <example>1609343999000</example>
        [JsonProperty("activated_time")]
        public long ActivatedTime { get; set; }
        /// <summary>
        /// 首次有效期结束时间，单位：毫秒
        /// </summary>
        /// <example>1609343999000</example>
        [JsonProperty("first_end_time")]
        public long FirstEndTime { get; set; }
    }

    /// <summary>
    /// 会员卡续费日志
    /// </summary>
    public class CustomerCardBuyLog
    {
        /// <summary>
        /// 续费日志列表
        /// </summary>
        [JsonProperty("renew_list")]
        public List<RenewInfo> RenewList { get; set; }
        /// <summary>
        /// 店铺在有赞的id标识，有赞平台生成，在有赞平台唯一，用于判断信息属于哪一个店铺
        /// </summary>
        /// <example>88888</example>
        [JsonProperty("kdt_id")]
        public long KdtId { get; set; }
        /// <summary>
        /// 会员卡号
        /// </summary>
        /// <example>3933653063540962821</example>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }
        /// <summary>
        /// 续期次数
        /// </summary>
        /// <example>1</example>
        [JsonProperty("renew_total")]
        public int RenewTotal { get; set; }
        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id
        /// </summary>
        /// <example>LnhGm4rh576452722916618240</example>
        [JsonProperty("yz_open_id")]
        public string YzOpenId { get; set; }
        /// <summary>
        /// 续费金额，单位：分
        /// </summary>
        /// <example>123</example>
        [JsonProperty("trade_total_fee")]
        public long TradeTotalFee { get; set; }
    }

    /// <summary>
    /// 续费日志
    /// </summary>
    public class RenewInfo
    {
        /// <summary>
        /// 有效期开始时间，单位：毫秒
        /// </summary>
        /// <example>1609343999000</example>
        [JsonProperty("term_begin_at")]
        public long TermBeginAt { get; set; }
        /// <summary>
        /// 用户续费唯一标识
        /// </summary>
        /// <example>33</example>
        [JsonProperty("renewal_id")]
        public long RenewalId { get; set; }
        /// <summary>
        /// 续费信息
        /// </summary>
        [JsonProperty("trade_track")]
        public TradeTrack TradeTrack { get; set; }
        /// <summary>
        /// 有效期结束时间，单位：毫秒
        /// </summary>
        /// <example>1609343999000</example>
        [JsonProperty("term_end_at")]
        public long TermEndAt { get; set; }
        /// <summary>
        /// 卡号(唯一)
        /// </summary>
        /// <example>3933653063540962821</example>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }
        /// <summary>
        /// 领卡时间，单位：毫秒
        /// </summary>
        /// <example>1609343999000</example>
        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }
        /// <summary>
        /// 卡id (唯一)
        /// </summary>
        /// <example>7233030</example>
        [JsonProperty("card_id")]
        public long CardId { get; set; }
    }

    /// <summary>
    /// 续费信息
    /// </summary>
    public class TradeTrack
    {
        /// <summary>
        /// 交易金额，单位：分
        /// </summary>
        /// <example>1</example>
        [JsonProperty("trade_fee")]
        public long TradeFee { get; set; }
        /// <summary>
        /// 交易流水号
        /// </summary>
        /// <example>E20201225124919049602074</example>
        [JsonProperty("tid")]
        public string Tid { get; set; }
    }
}
