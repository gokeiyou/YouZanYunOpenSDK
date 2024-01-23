using System.Collections.Generic;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    /// <summary>
    /// 获取客户列表参数
    /// </summary>
    public class UserCustomerSearchRequest : YouZanRequest
    {
        /// <summary>
        /// 成为会员的时间，单位是秒
        /// </summary>
        [ApiField("created_member_start")]
        public long? CreatedMemberStart { get; set; }
        
        /// <summary>
        /// 成为会员的时间，单位是秒
        /// </summary>
        [ApiField("created_member_end")]
        public long? CreatedMemberEnd { get; set; }
        
        /// <summary>
        /// 用户标签列表
        /// </summary>
        [ApiField("tag_ids")]
        public List<long> TagIds { get; set; }

        /// <summary>
        /// 是否有手机号、true=有，false=没有
        /// </summary>
        [ApiField("has_mobile")]
        public bool? HasMobile { get; set; }

        /// <summary>
        /// 成为客户的时间，起始值，时间戳格式，单位是秒
        /// </summary>
        [ApiField("created_at_start")]
        public long? CreatedAtStart { get; set; }

        /// <summary>
        /// 成为客户的时间，起始值，时间戳格式，单位是秒
        /// </summary>
        [ApiField("created_at_end")]
        public long? CreatedAtEnd { get; set; }

        /// <summary>
        /// 是否为会员，0表示非会员，1表示会员
        /// </summary>
        [ApiField("is_member")]
        public short? IsMember { get; set; }

        /// <summary>
        /// 页码，最多支持500页(500页是以每页默认值20为单位，客户查询最大为10000)
        /// </summary>
        [ApiField("page")]
        public int Page { get; set; } = 1;
        
        /// <summary>
        /// 每页数量，最多支持50个
        /// </summary>
        [ApiField("page_size")]
        public int PageSize { get; set; } = 50;
    }
}