using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    public class ScrmCustomerPointsGetRequest : YouZanRequest
    {
        /// <summary>
        /// 用户
        /// </summary>
        [ApiField("user")]
        public ParamUser User { get; set; }
        /// <summary>
        /// 是否需要走扩展点，默认：true（扩展点：）详见文档
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/EXT/35"/>
        [ApiField("is_do_extpoint")]
        public bool? IsDoExtPoint { get; set; }
    }
}