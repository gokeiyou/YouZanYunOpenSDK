using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 获取C端用户等级返回实体
    /// </summary>
    public class ScrmLevelGetUserLevelResponse
    {
        /// <summary>
        /// 等级名称
        /// </summary>
        [JsonProperty("level_name")]
        public string levelName { get; set; }
        /// <summary>
        /// 获得等级时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("term_begin_at")]
        public DateTime TermBeginAt { get; set; }
        /// <summary>
        /// 用户状态（0:不可用,1:可用,2:冻结）
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
        /// <summary>
        /// 设置后的等级值
        /// </summary>
        [JsonProperty("level_alias")]
        public string LevelAlias { get; set; }
        /// <summary>
        /// 用户等级值
        /// </summary>
        [JsonProperty("level_value")]
        public int LevelValue { get; set; }
        /// <summary>
        /// 等级截止时间 yyyy-MM-dd HH:mm:ss（(如果是1970-01-01 08:00:00 表示为永久有效)）
        /// </summary>
        [JsonProperty("term_end_at")]
        public DateTime TermEndAt { get; set; }
    }
}
