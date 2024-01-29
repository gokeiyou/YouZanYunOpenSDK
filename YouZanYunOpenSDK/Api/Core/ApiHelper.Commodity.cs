using YouZan.Open.Api.Constant;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Response;
using YouZan.Open.Api.Entry.Response.Items;

namespace YouZan.Open.Api
{
    /// <summary>
    /// 商品模块API
    /// </summary>
    /// <see cref="https://doc.youzanyun.com/list/API/1289"/>
    public partial class ApiHelper
    {
        /// <summary>
        /// 获取出售中的商品列表，可获取微商城全部商品信息
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<ItemsOnsaleGetResponse> ItemsOnSaleGet(YouZanRequest request)
        {
            return ApiInvoke<ItemsOnsaleGetResponse>(request,
                ApiConst.ITEMS_ONSALE_GET,
                ApiConst.VERSION_3_0_0);
        }


        public YouZanResponse<ItemGetResponse> ItemGet(YouZanRequest request)
        {
            return ApiInvoke<ItemGetResponse>(request,
                ApiConst.ITEM_GET,
                ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// 根据编码和商品类型查询查询商品标准
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns></returns>
        public YouZanResponse<ItemStandardGetResponse> ItemStandardGet(YouZanRequest request)
        {
            return ApiInvoke<ItemStandardGetResponse>(request,
                ApiConst.ITEM_STANDARD_GET,
                ApiConst.VERSION_1_0_0);
        }
    }
}
