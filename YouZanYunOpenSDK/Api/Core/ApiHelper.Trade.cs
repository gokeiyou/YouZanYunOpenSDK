using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Api.Constant;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Response;
using YouZan.Open.Api.Entry.Response.Trade;

namespace YouZan.Open.Api
{
    /// <summary>
    /// 交易模块API
    /// </summary>
    /// <see cref="https://doc.youzanyun.com/list/API/1292"/>
    public partial class ApiHelper
    {
        /// <summary>
        /// 更新备注
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/137"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse> TradeMemoUpdate(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse>(request,
                API.TRADE_MEMO_UPDATE,
                API.VERSION_3_0_0);
        }

        /// <summary>
        /// 查询单笔交易详情接口
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/120"/>
        /// <returns></returns>
        public YouZanResponse<TradeGetResponse> TradesGet(YouZanRequest request)
        {
            return ApiInvoke<TradeGetResponse>(request,
                API.TRADE_GET,
                API.VERSION_4_0_0);
        }
    }
}
