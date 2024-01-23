using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 获取C端用户等级参数实体
    /// </summary>
    public class ScrmLevelGetUserLevelRequest : YouZanRequest
    {
        /// <summary>
        /// 用户
        /// </summary>
        [ApiField("user")]
        public ParamUser User { get; set; }
        /// <summary>
        /// 等级类型;
        /// 1：成长值等级;
        /// 2：付费等级;
        /// 3：消费行为等级
        /// 不传默认为1；
        /// </summary>
        /// <example>1</example>
        [ApiField("type")]
        public int Type { get; set; }
    }
}
