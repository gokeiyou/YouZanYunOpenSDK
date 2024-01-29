using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Api.Constant;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Response;
using YouZan.Open.Api.Entry.Response.Customer;
using static System.Net.WebRequestMethods;

namespace YouZan.Open.Api
{
    /// <summary>
    /// 客户模块API
    /// </summary>
    /// <see cref="https://doc.youzanyun.com/list/API/1288"/>
    public partial class ApiHelper
    {
        /// <summary>
        /// 商家删除权益卡
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/293"/>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse> ScrmCardDelete(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse>(
                request,
                ApiConst.SCRM_CARD_DELETE,
                ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// 给多个客户批量打标签接口
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/552"/>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<bool> ScrmTagAddForMany(YouZanRequest request)
        {
            return ApiInvoke<bool>(
                request,
                ApiConst.SCRM_TAG_ADD_FOR_MANY,
                ApiConst.VERSION_1_0_0);
        }

        /// <summary>
        /// 获取店铺的办理会员页面链接(计费API)
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/762"/>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<ScrmSouGouMemberJoinLinkResponse> ScrmSouGouMemberJoinLink(YouZanRequest request)
        {
            return ApiInvoke<ScrmSouGouMemberJoinLinkResponse>(
                request,
                ApiConst.SCRM_SOUGOU_MEMBER_JOIN_LINK,
                ApiConst.VERSION_1_0_0);
        }

        /// <summary>
        /// 积分商城兑换商品查询接口(仅微商城使用)(计费)
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/695"/>
        /// <param name="request"></param>
        public YouZanResponse<CrmCustomerPointStoreListGoodsResponse> CrmCustomerPointStoreListGoods(YouZanRequest request)
        {
            return ApiInvoke<CrmCustomerPointStoreListGoodsResponse>(
                request,
                ApiConst.CRM_CUSTOMER_POINT_STORE_LIST_GOODS,
                ApiConst.VERSION_1_0_0);
        }

        /// <summary>
        /// 获取用户积分兑换记录(计费)
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/886"/>
        /// <param name="request"></param>
        public YouZanResponse<CrmCustomerPointStoreExchangeRecordsResponse> CrmCustomerPointStoreExchangeRecords(YouZanRequest request)
        {
            return ApiInvoke<CrmCustomerPointStoreExchangeRecordsResponse>(
                request,
                ApiConst.CRM_CUSTOMER_POINT_STORE_EXCHANGE_RECORDS,
                ApiConst.VERSION_2_0_0);
        }

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
                ApiConst.SCRM_CUSTOMER_GET_RECORD,
                ApiConst.VERSION_1_0_0);
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
                ApiConst.CRM_CUSTOMER_POINTGOODS_DELETE,
                ApiConst.VERSION_1_0_0);
        }

        /// <summary>
        /// 查询用户接口操作积分日志，支持查询所有来源积分日志。
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3410"/>
        /// <returns></returns>
        public YouZanResponse<CrmCustomerPointsChangeLogSearchResponse> CrmCustomerPointsChangeLogSearch(
            YouZanRequest request)
        {
            return ApiInvoke<CrmCustomerPointsChangeLogSearchResponse>(
                request,
                ApiConst.CRM_CUSTOMER_POINTS_CHANGELOG_SEARCH,
                ApiConst.VERSION_4_0_2);
        }

        /// <summary>
        /// 获取用户C端等级信息（免费、付费）
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3134"/>
        /// <returns></returns>
        public YouZanResponse<ScrmLevelGetUserLevelResponse> ScrmLevelGetUserLevel(YouZanRequest request)
        {
            return ApiInvoke<ScrmLevelGetUserLevelResponse>(
                request,
                ApiConst.SCRM_LEVEL_GET_USER_LEVEL,
                ApiConst.VERSION_1_0_0);
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
        public YouZanResponse<SuccessResponse> ScrmCustomerCardDelete(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse>(
                request,
                ApiConst.SCRM_CUSTOMER_CARD_DELETE,
                ApiConst.VERSION_4_0_0);
        }

        /// <summary>
        /// 查询权益卡下对应的会员列表
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/94"/>
        /// <returns></returns>
        public YouZanResponse<ScrmCustomerSearchResponse> ScrmCustomerSearch(YouZanRequest request)
        {
            return ApiInvoke<ScrmCustomerSearchResponse>(
                request,
                ApiConst.SCRM_CUSTOMER_SEARCH,
                ApiConst.VERSION_3_0_0);
        }

        /// <summary>
        /// 给客户减成长值
        /// 给客户减成长值，帐号类型(与帐户ID配合使用: 1:粉丝(原fansId),2:手机号,3:三方帐号(原open_user_id),4:UnionID,5:有赞客户唯一id即yz_open_id
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/864"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse> CrmCustomerGrowthDecrease(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse>(
                request,
                ApiConst.CRM_CUSTOMER_GROWTH_DECREASE,
                ApiConst.VERSION_2_0_0);
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
                ApiConst.CRM_CUSTOMER_GROWTH_LIST,
                ApiConst.VERSION_2_0_0);
        }

        /// <summary>
        /// 查询客户标签列表
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/4106"/>
        /// <returns></returns>
        public YouZanResponse<ScrmTagRelationQueryResponse> ScrmTagRelationQuery(YouZanRequest request)
        {
            return ApiInvoke<ScrmTagRelationQueryResponse>(
                request,
                ApiConst.SCRM_TAG_RELATION_QUERY,
                ApiConst.VERSION_1_0_0
            );
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
                ApiConst.SCRM_CARD_GET_GOODS_INFO,
                ApiConst.VERSION_1_0_0);
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
                ApiConst.SCRM_TAG_RELATION_ADD,
                ApiConst.VERSION_4_0_0);
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
                ApiConst.SCRM_CUSTOMER_LIST_PHONE,
                ApiConst.VERSION_1_0_0);
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
                ApiConst.CRM_CUSTOMER_POINTS_OPERATE_FREEZE_CONSUME,
                ApiConst.VERSION_4_0_0);
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
                ApiConst.SCRM_CUSTOMER_CREATE,
                ApiConst.VERSION_3_0_0);
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
                ApiConst.SCRM_TAG_RELATION_DELETE,
                ApiConst.VERSION_4_0_0);
        }

        /// <summary>
        /// 查询标签组详情
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public YouZanResponse<ScrmTagCategoryGetResponse> ScrmTagCategoryGet(YouZanRequest request)
        {
            return ApiInvoke<ScrmTagCategoryGetResponse>(
                request,
                ApiConst.SCRM_TAG_CATEGORY_GET,
                ApiConst.VERSION_1_0_0);
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
                ApiConst.SCRM_CUSTOMER_CARD_LIST,
                ApiConst.VERSION_4_0_0);
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
        public YouZanResponse<ScrmCustomerPointsGetResponse> CrmCustomerPointsGet(YouZanRequest request)
        {
            return ApiInvoke<ScrmCustomerPointsGetResponse>(
                request,
                ApiConst.CRM_CUSTOMER_POINTS_GET,
                ApiConst.VERSION_1_0_0);
        }

        /// <summary>
        /// 给用户减积分
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店、零售单店、有赞连锁D-总部、有赞连锁L-总部、有赞连锁L-总部-高级版、教育多校区-总部
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/873"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse> CrmCustomerPointsDecrease(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse>(
                request,
                ApiConst.CRM_CUSTOMER_POINTS_DECREASE,
                ApiConst.VERSION_4_0_0);
        }

        /// <summary>
        /// 同步客户积分
        /// API描述：同步客户积分（根据传参覆盖掉用户当前积分值，例 A有200积分，传参需要同步后的用户积分为10，则会扣除A 190个积分，将A的积分修改为10） 限制条件：同一店铺同一用户10s内只能操作一次同步积分
        /// </summary>
        /// <remarks>
        /// 已支持：微商城单店
        /// </remarks>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/883"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse> CrmCustomerPointsSync(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse>(
                request,
                ApiConst.CRM_CUSTOMER_POINTS_SYNC,
                ApiConst.VERSION_4_0_0);
        }

        /// <summary>
        /// 增加用户积分接口（有效期积分）
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3050"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse> CrmCustomerPointsOperateIncreaseWithExpire(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse>(
                request,
                ApiConst.CRM_CUSTOMER_POINTS_OPERATE_INCREASE_WITH_EXPIRE,
                ApiConst.VERSION_4_0_0);
        }

        /// <summary>
        /// 通过用户权益卡号获取会员信息
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/93"/>
        /// <returns></returns>
        public YouZanResponse<ScrmCustomerInfoGetResponse> ScrmCustomerInfoGet(YouZanRequest request)
        {
            return ApiInvoke<ScrmCustomerInfoGetResponse>(
                request,
                ApiConst.SCRM_CUSTOMER_INFO_GET,
                ApiConst.VERSION_3_0_0);
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
                ApiConst.CRM_CUSTOMER_POINTS_INCREASE,
                ApiConst.VERSION_4_0_0);
        }

        /// <summary>
        /// 解冻用户积分
        /// </summary>
        /// <param name="request"></param>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/2673"/>
        /// <returns></returns>
        public YouZanResponse<SuccessResponse<string>> ScrmCustomerPointsOperateUnfreeze(YouZanRequest request)
        {
            return ApiInvoke<SuccessResponse<string>>(request,
                ApiConst.SCRM_CUSTOMER_POINTS_OPERATE_UNFREEZE,
                ApiConst.VERSION_1_0_0);
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
                ApiConst.CRM_CUSTOMER_GROWTH_INCREASE,
                ApiConst.VERSION_2_0_0);
        }
    }
}