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
        /// 给客户减成长值
        /// 给客户减成长值，帐号类型(与帐户ID配合使用: 1:粉丝(原fansId),2:手机号,3:三方帐号(原open_user_id),4:UnionID,5:有赞客户唯一id即yz_open_id
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/864"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse> CrmCustomerGrowthDecrease(YouZanRequest request) {
            return ApiInvoke<SuccessResponse>(
                request,
                API.CRM_CUSTOMER_GROWTH_DECREASE,
                API.VERSION_2_0_0);
        }

        /// <summary>
        /// 批量获取客户成长值，只支持根据手机号和yz_open_id有赞客户唯一id查询，最大支持一次查询50条客户信息
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/861"/>
        /// <returns></returns>
        public YouZanResponse<CrmCustomerGrowthListResponse> CrmCustomerGrowthList(YouZanRequest request)
        {
            return ApiInvoke<CrmCustomerGrowthListResponse>(
                request,
                API.CRM_CUSTOMER_GROWTH_LIST,
                API.VERSION_2_0_0);
        }

        /// <summary>
        /// 查询付费权益卡商品id
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3280"/>
        /// <returns></returns>
        public YouZanResponse<ScrmCardGetGoodsInfoResponse> ScrmCardGetGoodsInfo(YouZanRequest request)
        {
            return ApiInvoke<ScrmCardGetGoodsInfoResponse>(
                request,
                API.SCRM_CARD_GET_GOODS_INFO,
                API.VERSION_1_0_0);
        }

        /// <summary>
        /// 给指定客户打上一组标签，标签不存在会自动创建
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/17"/>
        /// <returns></returns>
        public YouZanResponse<bool> ScrmTagRelationAdd(YouZanRequest request)
        {
            return ApiInvoke<bool>(
                request,
                API.SCRM_TAG_RELATION_ADD,
                API.VERSION_4_0_0);
        }

        /// <summary>
        /// 根据手机号批量查询客户信息
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3220"/>
        /// <returns></returns>
        public YouZanResponse<ScrmCustomerListPhoneResponse> ScrmCustomerListPhone(YouZanRequest request)
        {
            return ApiInvoke<ScrmCustomerListPhoneResponse>(
                request,
                API.SCRM_CUSTOMER_LIST_PHONE,
                API.VERSION_1_0_0);
        }

        /// <summary>
        /// 冻结&消费用户积分，冻结消费积分原子接口
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3048"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse<string>> CrmCustomerPointsOperateFreezeAndConsume(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse<string>>(
                request,
                API.CRM_CUSTOMER_POINTS_OPERATE_FREEZE_CONSUME,
                API.VERSION_4_0_0);
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
        /// 删除客户标签
        /// 1.删除指定客户身上的指定标签，标签不存在或客户身上没这个标签不会返回错误。 2.最大支持一次请求删除20个标签。
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/18"/>
        /// <returns></returns>
        public YouZanResponse<bool> ScrmTagRelationDelete(YouZanRequest request)
        {
            return ApiInvoke<bool>(
                request,
                API.SCRM_TAG_RELATION_DELETE,
                API.VERSION_4_0_0);
        }

        /// <summary>
        /// 获取客户账号下权益卡列表
        /// 获取用户的权益卡列表（列表不返回卡模板禁用的卡、未激活的卡和过期的卡）
        /// 支持的用户账号类型
        /// 1-有赞粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id) ;
        /// 2-手机号;
        /// 3-三方帐号(原open_user_id:三方App用户ID，该参数仅限购买App开店插件的商家使用) ;
        /// 5-有赞用户id，用户在有赞的唯一id。推荐使用）
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、零售单店、有赞连锁D-总部、有赞连锁D-网店、有赞连锁D-合伙人、教育多校区-总部
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/869"/>
        /// <returns></returns>
        public YouZanResponse<PageResponse<ScrmCustomerCardListResponse>> ScrmCustomerCardList(YouZanRequest request)
        {
            return ApiInvoke<PageResponse<ScrmCustomerCardListResponse>>(
                request,
                API.SCRM_CUSTOMER_CARD_LIST,
                API.VERSION_4_0_0);
        }

        /// <summary>
        /// 查询用户当前积分
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、零售单店、有赞连锁D-总部、有赞连锁L-总部、有赞连锁L-总部-高级版
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/884"/>
        /// <returns></returns>
        public YouZanResponse<ScrmCustomerPointsGetResponse> ScrmCustomerPointsGet(YouZanRequest request)
        {
            return ApiInvoke<ScrmCustomerPointsGetResponse>(
                request,
                API.SCRM_CUSTOMER_POINTS_GET,
                API.VERSION_1_0_0);
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
