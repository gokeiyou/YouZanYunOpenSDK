using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Models.Request.Customer
{
    /// <summary>
    /// 获取该商家的会员等级模版列表 请求参数
    /// </summary>
    public class ScrmLevelListRequest : YouZanRequest
    {
        /// <summary>
        /// 等级类型( 默认为1:免费 , 2:付费)
        /// </summary>
        [ApiField("level_type")]
        public int? LevelType { get; set; }
    }
}