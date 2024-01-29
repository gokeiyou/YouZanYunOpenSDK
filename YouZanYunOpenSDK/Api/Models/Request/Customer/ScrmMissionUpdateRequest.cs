using System;
using System.Collections.Generic;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 任务中心-C端任务更新（任务完成调用） 请求参数
    /// </summary>
    public class ScrmMissionUpdateRequest : YouZanRequest
    {
        /// <summary>
        /// 任务模板类型必传
        /// </summary>
        [ApiField("mission_tpl_type")]
        public string MissionTemplateType { get; set; }

        /// <summary>
        /// C端任务状态类型：0-开始,10-进行中,20-终止,25-任务模板被禁用,30-结束
        /// </summary>
        [ApiField("state")]
        public int State { get; set; }

        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id
        /// </summary>
        [ApiField("yz_open_id")]
        public string YzOpenId { get; set; }

        /// <summary>
        /// 操作人昵称
        /// </summary>
        [ApiField("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 任务执行次数可为空
        /// </summary>
        [ApiField("times")]
        public int? Times { get; set; }

        /// <summary>
        /// 操作人ID
        /// </summary>
        [ApiField("operator_id")]
        public long? OperatorId { get; set; }

        /// <summary>
        /// 扩展信息(可为空)
        /// </summary>
        [ApiField("ext_info")]
        public Dictionary<string, string> ExtensionInfo { get; set; }

        /// <summary>
        /// 任务最后执行时间（可为空）
        /// </summary>
        [ApiField("last_execute_at")]
        public DateTime? LastExecuteAt { get; set; }
    }
}