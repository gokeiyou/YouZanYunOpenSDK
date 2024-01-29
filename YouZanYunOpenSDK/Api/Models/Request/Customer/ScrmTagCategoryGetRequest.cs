using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    public class ScrmTagCategoryGetRequest : YouZanRequest
    {
        /// <summary>
        /// 查询标签组详情
        /// </summary>
        [ApiField("tag_category_id")]
        public long TagCategoryId { get; set; }
    }
}