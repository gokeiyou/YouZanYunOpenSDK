using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Salesman
{
    /// <summary>
    /// 设置用户成为分销员API请求参数实体
    /// </summary>
    public class SalesmanAccountAddRequest : YouZanRequest
    {
        /// <summary>
        /// 需要设置的等级
        /// </summary>
        [ApiField("level")]
        public int? Level { get; set; }

        /// <summary>
        /// 所属分组id
        /// </summary>
        [ApiField("group_id")]
        public long? GroupId { get; set; }

        /// <summary>
        /// 分销员手机号
        /// mobile或fans_id选其一，另者置为0
        /// 当fans_id和mobile都传时，优先按mobile查询
        /// </summary>
        [ApiField("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 粉丝类型
        /// 自有粉丝: fans_type = 1
        /// 当传mobile时，和fans_id一样传0）
        /// </summary>
        [ApiField("fans_type")]
        public int FansType { get; set; }

        /// <summary>
        /// 上级分销员的手机号
        /// </summary>
        [ApiField("from_mobile")]
        public string FromType { get; set; }

        /// <summary>
        /// 粉丝id
        /// mobile或fans_id选其一，另者置为0
        /// 当fans_id和mobile都传时，优先按mobile查询
        /// </summary>
        [ApiField("fans_id")]
        public long FansId { get; set; }
    }
}
