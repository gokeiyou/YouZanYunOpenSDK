using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 通过用户权益卡号获取会员信息，返回参数
    /// </summary>
    public class ScrmCustomerInfoGetResponse
    {
        /// <summary>
        /// 手机号码，与fansId两者二选一
        /// </summary>
        [ApiField("mobile")]
        public string Mobile { get; set; }
        /// <summary>
        /// 权益卡激活时间，时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [ApiField("activated_time")]
        public string ActivatedTime { get; set; }
        /// <summary>
        /// 粉丝类型fansType，与fansId成对出现，目前只支持=1
        /// </summary>
        [ApiField("fans_type")]
        public short FansType { get; set; } = 1;
        /// <summary>
        /// 粉丝ID,与mobile两者二选一
        /// </summary>
        [ApiField("fans_id")]
        public long FansId { get; set; }
        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id
        /// </summary>
        [ApiField("yz_open_id")]
        public string YouZanOpenId { get; set; }
        /// <summary>
        /// 权益卡有效期开始时间，时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [ApiField("card_start_time")]
        public string CardStartTime { get; set; }
        /// <summary>
        /// 权益卡有效期结束时间，时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [ApiField("card_end_time")]
        public string CardEndTime { get; set; }
        /// <summary>
        /// 领卡时间，时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [ApiField("take_card_time")]
        public string TakeCardTime { get; set; }
        /// <summary>
        /// 会员姓名
        /// </summary>
        [ApiField("name")]
        public string Name { get; set; }
        /// <summary>
        /// 权益卡别名
        /// </summary>
        [ApiField("card_alias")]
        public string CardAlias { get; set; }
        /// <summary>
        /// 是否是体验卡
        /// </summary>
        [ApiField("is_experience_card")]
        public bool IsExperienceCard { get; set; }
        /// <summary>
        /// 权益卡名称
        /// </summary>
        [ApiField("card_name")]
        public string CardName { get; set; }
    }
}