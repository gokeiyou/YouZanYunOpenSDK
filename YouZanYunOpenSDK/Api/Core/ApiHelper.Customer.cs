using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Api.Constant;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Response;
using YouZan.Open.Api.Entry.Response.Customer;

namespace YouZan.Open.Api
{
    /// <summary>
    /// 客户模块API
    /// </summary>
    /// <see cref="https://doc.youzanyun.com/list/API/1288"/>
    public partial class ApiHelper
    {

        /// <summary>
        /// 根据卡号获取用户购卡记录
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/2107"/>
        /// <returns></returns>
        public YouZanResponse<ScrmCustomerGetRecordResponse> ScrmCustomerGetRecord(YouZanRequest request)
        {
            return ApiInvoke<ScrmCustomerGetRecordResponse>(
                request,
                API.SCRM_CUSTOMER_GET_RECORD,
                API.VERSION_1_0_0);
        }

        /// <summary>
        /// 根据商品id，kdtId等，删除积分商品
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/1068"/>
        /// <returns></returns>
        public YouZanResponse CrmCustomerPointGoodsDelete(YouZanRequest request)
        {
            return ApiInvoke(
                request,
                API.CRM_CUSTOMER_POINTGOODS_DELETE,
                API.VERSION_1_0_0);
        }

        /// <summary>
        /// 查询用户接口操作积分日志，支持查询所有来源积分日志。
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3410"/>
        /// <returns></returns>
        public YouZanResponse<CrmCustomerPointsChangeLogSearchResponse> CrmCustomerPointsChangeLogSearch(YouZanRequest request)
        {
            return ApiInvoke<CrmCustomerPointsChangeLogSearchResponse>(
                request,
                API.CRM_CUSTOMER_POINTS_CHANGELOG_SEARCH,
                API.VERSION_4_0_2);
        }

        /// <summary>
        /// 获取用户C端等级信息（免费、付费）
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3134"/>
        /// <returns></returns>
        public YouZanResponse<ScrmLevelGetUserLevelResponse> ScrmLevelGetUserLevel(YouZanRequest request) {
            return ApiInvoke<ScrmLevelGetUserLevelResponse>(
                request,
                API.SCRM_LEVEL_GET_USER_LEVEL,
                API.VERSION_1_0_0);
        }

        /// <summary>
        /// 删除用户的权益卡
        /// 1、删除用户的权益卡支持的用户账号类型
        ///     1）有赞粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id) ;
        ///     2）手机号;
        ///     3）三方帐号(原open_user_id:三方App用户ID，该参数仅限购买App开店插件的商家使用) ;
        ///     5）有赞用户id，用户在有赞的唯一id。推荐使用）
        /// 2、仅支持零售连锁总部调用
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/870"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse> ScrmCustomerCardDelete(YouZanRequest request) {
            return ApiInvoke<SuccessResponse>(
                request,
                API.SCRM_CUSTOMER_CARD_DELETE,
                API.VERSION_4_0_0);
        }

        /// <summary>
        /// 查询权益卡下对应的会员列表
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/94"/>
        /// <returns></returns>
        public YouZanResponse<ScrmCustomerSearchResponse> ScrmCustomerSearch(YouZanRequest request) {
            return ApiInvoke<ScrmCustomerSearchResponse>(
                request,
                API.SCRM_CUSTOMER_SEARCH,
                API.VERSION_3_0_0);
        }

        /// <summary>
        /// 查询权益卡下对应的会员列表
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/94"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse> CrmCustomerGrowthDecrease(YouZanRequest request) {
            return ApiInvoke<SuccessResponse>(
                request,
                API.CRM_CUSTOMER_GROWTH_DECREASE,
                API.VERSION_2_0_0);
        }

        /// <summary>
        /// 创建客户
        /// 手机号和{"name":"丽丽"}必填
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/92"/>
        /// <returns></returns>
        public YouZanResponse<ScrmCustomerCreateResponse> ScrmCustomerCreate(YouZanRequest request)
        {
            return ApiInvoke<ScrmCustomerCreateResponse>(
                request,
                API.SCRM_CUSTOMER_CREATE,
                API.VERSION_3_0_0);
        }

        /// <summary>
        /// 给用户加积分，注意仅支持总部加积分，不支持网店或分店增加积分 支持的用户账号类型 1-有赞粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id) ; 2-手机号; 3-三方帐号(原open_user_id:三方App用户ID，该参数仅限购买App开店插件的商家使用) ; 5-有赞用户id，用户在有赞的唯一id。推荐使用）； 注意：不要针对同一个客户做并发加/减积分操作。
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/872"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse> CrmCustomerPointsIncrease(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse>(request,
                API.CRM_CUSTOMER_POINTS_INCREASE,
                API.VERSION_4_0_0);
        }

        /// <summary>
        /// 给客户加成长值，帐号类型(与帐户ID配合使用: 1:粉丝(原fansId),2:手机号,3:三方帐号(原open_user_id),4:UnionID,5:有赞客户唯一id即yz_open_id
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/863"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse> CrmCustomerGrowthIncrease(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse>(request,
                API.CRM_CUSTOMER_GROWTH_INCREASE,
                API.VERSION_2_0_0);
        }

    }
}
