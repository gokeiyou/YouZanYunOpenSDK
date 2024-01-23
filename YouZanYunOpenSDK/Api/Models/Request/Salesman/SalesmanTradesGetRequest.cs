using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Salesman
{
    public class SalesmanTradesGetRequest : YouZanRequest
    {

        /// <summary>
        /// 订单号
        /// </summary>
        [ApiField("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 查询开始时间（时间戳，单位秒）
        /// </summary>
        [ApiField("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 查询结束时间（时间戳，单位秒）
        /// </summary>
        [ApiField("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 手机号（mobile或fans_id选其一，另者置为0，当fans_id和mobile都传时，优先按mobile查询）
        /// </summary>
        [ApiField("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 粉丝类型（自有粉丝: fans_type = 1；当传mobile时，和fans_id一样传0）
        /// </summary>
        [ApiField("fans_type")]
        public int FansType { get; set; }

        /// <summary>
        /// 粉丝id（mobile或fans_id选其一，另者置为0，当fans_id和mobile都传时，优先按mobile查询）
        /// </summary>
        [ApiField("fans_id")]
        public int FansId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [ApiField("page_no")]
        public int PageNo { get; set; }

        /// <summary>
        /// 每页记录数（最大100）
        /// </summary>
        [ApiField("page_size")]
        public int PageSize { get; set; }



    }
}
