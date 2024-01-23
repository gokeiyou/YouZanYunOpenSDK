using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Customer
{
    /// <summary>
    /// 查询客户标签列表 返回值实体
    /// </summary>
    public class ScrmTagRelationQueryResponse
    {
        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("tags")]
        public List<ScrmTagRelationQueryTag> TagList { get; set; }

        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id。推荐使用
        /// </summary>
        /// <example>LnhGm4rh576452722916618240</example>
        [JsonProperty("yz_open_id")]
        public string YouZanOpenId { get; set; }
    }

    public class ScrmTagRelationQueryTag
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        /// <example>标签名称</example>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签Id
        /// </summary>
        /// <example>123</example>
        [JsonProperty("tag_id")]
        public long TagId { get; set; }

        /// <summary>
        /// 标签类目名称
        /// </summary>
        /// <example>标签类目名称</example>
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 标签类目Id
        /// </summary>
        /// <example>12312</example>
        [JsonProperty("category_id")]
        public long CategoryId { get; set; }
    }
}