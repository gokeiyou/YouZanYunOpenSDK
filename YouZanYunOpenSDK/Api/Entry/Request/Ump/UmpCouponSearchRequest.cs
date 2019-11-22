using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Ump
{
    public class UmpCouponSearchRequest : YouZanRequest
    {

        /// <summary>
        /// 第几页
        /// </summary>
        [ApiField("page_no")]
        public int PageNo { get; set; }

        /// <summary>
        /// 每页数量，建议传值20，最大支持50.
        /// </summary>
        [ApiField("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// 活动状态。
        /// FUTURE：未开始
        /// END：已结束
        /// ON：进行中 （默认查所有状态）
        /// </summary>
        [ApiField("status")]
        public string Status { get; set; }

        /// <summary>
        /// 活动类型
        /// PROMOCARD：优惠券
        /// PROMOCODE：优惠码
        /// </summary>
        [ApiField("group_type")]
        public string GroupType { get; set; }

    }
}
