using YouZan.Open.Api.Constant;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Response;
using YouZan.Open.Api.Entry.Response.Salesman;

namespace YouZan.Open.Api
{
    /// <summary>
    /// 分销模块API
    /// </summary>
    /// <see cref="https://doc.youzanyun.com/list/API/1302"/>
    public partial class ApiHelper
    {
        /// <summary>
        /// 获取分销员账户信息，不支持返回分销员等级
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/67"/>
        /// <returns></returns>
        public YouZanResponse<SalesmanAccountGetResponse> SalesmanAccountGet(YouZanRequest request)
        {
            return ApiInvoke<SalesmanAccountGetResponse>(
                request,
                ApiConst.SALESMAN_ACCOUNT_GET,
                ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// 设置用户为分销员
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/41"/>
        /// <returns></returns>
        public YouZanResponse<SalesmanAccountAddResponse> SalesmanAccountAdd(YouZanRequest request)
        {
            return ApiInvoke<SalesmanAccountAddResponse>(
                request,
                ApiConst.SALESMAN_ACCOUNT_ADD,
                ApiConst.VERSION_3_0_1);
        }

        /// <summary>
        /// 更新分销员信息,客户已经是分销员才可以更新
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/42"/>
        /// <returns></returns>
        public YouZanResponse<SalesmanAccountUpdateResponse> SalesmanAccountUpdate(YouZanRequest request)
        {
            return ApiInvoke<SalesmanAccountUpdateResponse>(
                request,
                ApiConst.SALESMAN_ACCOUNT_UPDATE,
                ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// 清退分销员，客户必须是分销员才能清退
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/345"/>
        /// <returns></returns>
        public YouZanResponse<bool> SalesmanAccountFire(YouZanRequest request)
        {
            return ApiInvoke<bool>(request,
                ApiConst.SALESMAN_ACCOUNT_FIRE,
                ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// 获取推广订单列表
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/74"/>
        /// <returns></returns>
        public YouZanResponse<SalesmanTradesGetResponse> SalesmanTradesGet(YouZanRequest request)
        {
            return ApiInvoke<SalesmanTradesGetResponse>(request,
                ApiConst.SALESMAN_TRADES_GET,
                ApiConst.VERSION_3_0_1);
        }

        /// <summary>
        /// 获取商品推广链接
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/43"/>
        /// <returns></returns>
        public YouZanResponse<SalesmanItemShareGetResponse> SalesmanItemShareGet(YouZanRequest request)
        {
            return ApiInvoke<SalesmanItemShareGetResponse>(request,
                ApiConst.SALESMAN_ITEM_SHARE_GET,
                ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// 获取分销员业绩统计
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/37"/>
        /// <returns></returns>
        public YouZanResponse<SalesmanAccountScoreSearchResponse> SalesmanAccountScoreSearch(YouZanRequest request)
        {
            return ApiInvoke<SalesmanAccountScoreSearchResponse>(request,
                ApiConst.SALESMAN_ACCOUNT_SCORE_SEARCH,
                ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// 批量获取商品提成比例信息
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/732"/>
        /// <returns></returns>
        public YouZanResponse<SalesmanItemsGetResponse> SalesmanItemsGet(YouZanRequest request)
        {
            return ApiInvoke<SalesmanItemsGetResponse>(request,
                ApiConst.SALESMAN_ITEMS_GET,
                ApiConst.VERSION_3_0_0);
        }
    }
}
