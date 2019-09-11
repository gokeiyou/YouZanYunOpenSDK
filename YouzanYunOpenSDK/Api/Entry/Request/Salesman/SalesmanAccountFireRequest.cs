using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Salesman
{
    public class SalesmanAccountFireRequest : YouZanRequest
    {

        /// <summary>
        /// 转移邀请关系到目标分销员手机号
        /// </summary>
        [ApiField("target_mobile")]
        public string TargetMobile { get; set; }

        /// <summary>
        /// 分销员手机号当fans和mobile都传时,优先按mobile查询
        /// </summary>
        [ApiField("mobile")]
        public string mobile { get; set; }

        /// <summary>
        /// 粉丝类型（自有粉丝: fans_type = 1；当传mobile时，和fans_id一样传0)
        /// </summary>
        [ApiField("fans_type")]
        public int fans_type { get; set; }

        /// <summary>
        /// 粉丝id（mobile或fans_id选其一，另者置为0，当fans_id和mobile都传时，优先按mobile查询）粉丝id
        /// </summary>
        [ApiField("fans_id")]
        public long fans_id { get; set; }

    }
}
