using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 查询标签组详情 响应实体
    /// </summary>
    public class ScrmTagCategoryGetResponse
    {
        /// <summary>
        /// 标签状态 1:已禁用 0:正常
        /// </summary>
        [JsonProperty("tag_category_id")]
        public long TagCategoryId { get; set; }

        /// <summary>
        /// 标签状态 1:已禁用 0:正常
        /// </summary>
        [JsonProperty("sync_external")]
        public bool SyncExternal { get; set; }

        /// <summary>
        /// 标签状态 1:已禁用 0:正常
        /// </summary>
        [JsonProperty("allow_view_roles")]
        public List<int> AllowViewRoles { get; set; }

        /// <summary>
        /// 标签状态 1:已禁用 0:正常
        /// </summary>
        [JsonProperty("kdt_id")]
        public long KdtId { get; set; }

        /// <summary>
        /// 标签状态 1:已禁用 0:正常
        /// </summary>
        [JsonProperty("tag_category_name")]
        public string TagCategoryName { get; set; }

        /// <summary>
        /// 标签状态 1:已禁用 0:正常
        /// </summary>
        [JsonProperty("tag_add_rule")]
        public int TagAddRule { get; set; }

        /// <summary>
        /// 标签状态 1:已禁用 0:正常
        /// </summary>
        [JsonProperty("support_tag_type")]
        public int SupportTagType { get; set; }

        /// <summary>
        /// 标签状态 1:已禁用 0:正常
        /// </summary>
        [JsonProperty("allow_edit_roles")]
        public List<int> AllowEditRoles { get; set; }

        /// <summary>
        /// 标签状态 1:已禁用 0:正常
        /// </summary>
        [JsonProperty("tag_category_status")]
        public int TagCategoryStatus { get; set; }
    }

    public class ScrmTagCategoryGetTag
    {
        /// <summary>
        /// 标签状态 1:已禁用 0:正常
        /// </summary>
        [JsonProperty("tag_status")]
        public int TagStatus { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签Id
        /// </summary>
        [JsonProperty("tag_id")]
        public long TagId { get; set; }
    }
}