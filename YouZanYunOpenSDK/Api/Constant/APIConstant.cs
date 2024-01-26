using static System.Net.WebRequestMethods;

namespace YouZan.Open.Api.Constant
{
    /// <summary>
    /// 常量定义
    /// </summary>
    public struct ApiConst
    {
        /// <summary>
        /// API请求域名
        /// </summary>
        internal const string HOST = "https://open.youzanyun.com";

        /// <summary>
        /// TOKEN请求地址
        /// </summary>
        internal const string TOKEN_URL = "https://open.youzanyun.com/auth/token";

        #region METHOD

        /// <summary>
        /// GET
        /// </summary>
        public const string HTTP_GET = "get";

        /// <summary>
        /// POST
        /// </summary>
        public const string HTTP_POST = "post";

        #endregion

        #region API版本

        /// <summary>
        /// 版本号：1.0.0
        /// </summary>
        public const string VERSION_1_0_0 = "1.0.0";

        /// <summary>
        /// 版本号：2.0.0
        /// </summary>
        public const string VERSION_2_0_0 = "2.0.0";

        /// <summary>
        /// 版本号：3.0.0
        /// </summary>
        public const string VERSION_3_0_0 = "3.0.0";

        /// <summary>
        /// 版本号：3.0.1
        /// </summary>
        public const string VERSION_3_0_1 = "3.0.1";

        /// <summary>
        /// 版本号：3.0.1
        /// </summary>
        public const string VERSION_3_0_2 = "3.0.2";

        /// <summary>
        /// 版本号：3.1.2
        /// </summary>
        public const string VERSION_3_1_2 = "3.1.2";

        /// <summary>
        /// 版本号：4.0.0
        /// </summary>
        public const string VERSION_4_0_0 = "4.0.0";

        /// <summary>
        /// 版本号：4.0.1
        /// </summary>
        public const string VERSION_4_0_1 = "4.0.1";

        /// <summary>
        /// 版本号：4.0.2
        /// </summary>
        public const string VERSION_4_0_2 = "4.0.2";

        #endregion

        #region API列表

        #region 用户API

        /// <summary>
        /// 获取有赞openId(收费)
        /// </summary>
        /// <remarks>
        /// 根据userId（有赞账号id）查询有赞openId(注意是有赞openId，非微信openId)
        /// </remarks>
        internal const string USER_OPENAPI_GET = "youzan.user.openid.get";

        /// <summary>
        /// 用户查询接口
        /// </summary>
        internal const string USERS_INFO_QUERY = "youzan.users.info.query";

        /// <summary>
        /// 根据关注时间段批量查询微信粉丝用户信息
        /// </summary>
        internal const string USERS_WEIXIN_FOLLOWS_INFO_SEARCH = "youzan.users.weixin.followers.info.search";

        /// <summary>
        /// 根据微信粉丝用户的 weixin_openid 或 fans_id 绑定对应的标签
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/103"/>
        internal const string USERS_WEIXIN_FOLLOWER_TAGS_ADD = "youzan.users.weixin.follower.tags.add";

        /// <summary>
        /// 获取单个粉丝标签集合
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/105"/>
        internal const string USERS_WEIXIN_FOLLOWER_TAGS_GET = "youzan.users.weixin.follower.tags.get";

        /// <summary>
        /// 根据微信粉丝用户的 weixin_openid 或 fans_id 删除对应的标签
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/133"/>
        internal const string USERS_WEIXIN_FOLLOWER_TAGS_DELETE = "youzan.users.weixin.follower.tags.delete";

        /// <summary>
        /// 生成微信小程序二维码（支持超过32可见字符的自定义参数）
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/910"/>
        internal const string USERS_CHANNEL_CODE_ULTRA_GET = "youzan.users.channel.code.ultra.get";

        /// <summary>
        /// 获取客户列表
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/755"/>
        internal const string USERS_SCRM_CUSTOMER_SEARCH = "youzan.scrm.customer.search";

        /// <summary>
        /// 删除三方帐号信息，用于App开店帐号一键授权
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3946"/>
        internal const string USERS_WECHAT_DELETE = "youzan.user.wechat.delete";

        /// <summary>
        /// 查询是否存在有赞帐号
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/21"/>
        internal const string USERS_ACCOUNT_CHECK = "youzan.users.account.check";

        /// <summary>
        /// 使用手机号获取用户微信openId
        /// </summary>
        internal const string USER_WEIXIN_OPENID_GET = "youzan.user.weixin.openid.get";

        /// <summary>
        /// 依据有赞openid 或者手机号 获取用户简要信息
        /// </summary>
        internal const string USER_BASIC_GET = "youzan.user.basic.get";

        /// <summary>
        /// App开店用户解绑(App开店专属接口)
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3833"/>
        internal const string USERS_APPSHOP_UNBIND = "youzan.users.appshop.unbind";

        /// <summary>
        /// 查询app开店的用户信息
        /// </summary>
        internal const string USER_APP_SHOP_GET_INFO = "youzan.user.appshop.get.info";

        #endregion

        #region 会员API

        /// <summary>
        /// 商家删除权益卡
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/293"/>
        internal const string SCRM_CARD_DELETE = "youzan.scrm.card.delete";

        /// <summary>
        /// 给多个客户批量打标签接口
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/552"/>
        internal const string SCRM_TAG_ADD_FOR_MANY = "youzan.scrm.tag.addformany";

        /// <summary>
        /// 获取店铺的办理会员页面链接
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/762"/>
        internal const string SCRM_SOUGOU_MEMBER_JOIN_LINK = "youzan.scrm.sougou.member.join.link";

        /// <summary>
        /// 积分商城兑换商品查询接口
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/695"/>
        internal const string CRM_CUSTOMER_POINT_STORE_LIST_GOODS = "youzan.crm.customer.pointstore.list.goods";

        /// <summary>
        /// 根据卡号获取用户购卡记录
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/2107"/>
        internal const string SCRM_CUSTOMER_GET_RECORD = "youzan.scrm.customer.get.record";

        /// <summary>
        /// 删除积分商城的积分商品信息
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/1068"/>
        internal const string CRM_CUSTOMER_POINTGOODS_DELETE = "youzan.crm.customer.pointgoods.delete";

        /// <summary>
        /// 查询用户积分日志
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3410"/>
        internal const string CRM_CUSTOMER_POINTS_CHANGELOG_SEARCH = "youzan.crm.customer.points.changelog.search";

        /// <summary>
        /// 获取C端用户等级
        /// </summary>
        internal const string SCRM_LEVEL_GET_USER_LEVEL = "youzan.scrm.level.get.userlevel";

        /// <summary>
        /// 获取C端用户等级
        /// </summary>
        internal const string SCRM_CUSTOMER_CARD_DELETE = "youzan.scrm.customer.card.delete";

        /// <summary>
        /// 查询权益卡下对应的会员列表
        /// </summary>
        internal const string SCRM_CUSTOMER_SEARCH = "youzan.scrm.customer.search";

        /// <summary>
        /// 给客户减成长值
        /// </summary>
        internal const string CRM_CUSTOMER_GROWTH_DECREASE = "youzan.crm.customer.growth.decrease";

        /// <summary>
        /// 批量获取客户成长值
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/861"/>
        internal const string CRM_CUSTOMER_GROWTH_LIST = "youzan.crm.customer.growth.list";

        /// <summary>
        /// 查询客户标签列表
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/4106"/>
        internal const string SCRM_TAG_RELATION_QUERY = "youzan.scrm.tagrelation.query";

        /// <summary>
        /// 查询付费权益卡商品id
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3280"/>
        internal const string SCRM_CARD_GET_GOODS_INFO = "youzan.scrm.card.get.goodsinfo";

        /// <summary>
        /// 给客户打标
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/17"/>
        internal const string SCRM_TAG_RELATION_ADD = "youzan.scrm.tag.relation.add";

        /// <summary>
        /// 根据手机号批量查询客户信息
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3220"/>
        internal const string SCRM_CUSTOMER_LIST_PHONE = "youzan.scrm.customer.list.phone";

        /// <summary>
        /// 冻结&消费用户积分
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3048"/>
        internal const string CRM_CUSTOMER_POINTS_OPERATE_FREEZE_CONSUME =
            "youzan.crm.customer.points.operate.freezeandconsume";

        /// <summary>
        /// 创建客户
        /// 手机号和{"name":"丽丽"}必填
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/92"/>
        internal const string SCRM_CUSTOMER_CREATE = "youzan.scrm.customer.create";

        /// <summary>
        /// 删除客户标签
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/18"/>
        internal const string SCRM_TAG_RELATION_DELETE = "youzan.scrm.tag.relation.delete";

        /// <summary>
        /// 查询标签组详情
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/4221"/>
        internal const string SCRM_TAG_CATEGORY_GET = "youzan.scrm.tag.category.get";

        /// <summary>
        /// 获取客户账号下权益卡列表
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/869"/>
        internal const string SCRM_CUSTOMER_CARD_LIST = "youzan.scrm.customer.card.list";

        /// <summary>
        /// 查询用户当前积分
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/884"/>
        internal const string CRM_CUSTOMER_POINTS_GET = "youzan.crm.customer.points.get";

        /// <summary>
        /// 给用户减积分
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/873"/>
        internal const string CRM_CUSTOMER_POINTS_DECREASE = "youzan.crm.customer.points.decrease";

        /// <summary>
        /// 同步客户积分
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/883"/>
        internal const string CRM_CUSTOMER_POINTS_SYNC = "youzan.crm.customer.points.sync";

        /// <summary>
        /// 增加有效期积分
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/3050"/>
        internal const string CRM_CUSTOMER_POINTS_OPERATE_INCREASE_WITH_EXPIRE =
            "youzan.crm.customer.points.operate.increasewithexpire";

        /// <summary>
        /// 通过用户权益卡号获取会员信息
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/93"/>
        internal const string SCRM_CUSTOMER_INFO_GET = "youzan.scrm.customer.info.get";

        #endregion

        #region 分销员API

        /// <summary>
        /// 获取分销员账户信息，不支持返回分销员等级
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/67"/>
        internal const string SALESMAN_ACCOUNT_GET = "youzan.salesman.account.get";

        /// <summary>
        /// 设置用户成为分销员
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/41"/>
        internal const string SALESMAN_ACCOUNT_ADD = "youzan.salesman.account.add";

        /// <summary>
        /// 更新分销员信息,客户已经是分销员才可以更新
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/42"/>
        internal const string SALESMAN_ACCOUNT_UPDATE = "youzan.salesman.account.update";

        /// <summary>
        /// 清退分销员，客户必须是分销员才能清退
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/345"/>
        internal const string SALESMAN_ACCOUNT_FIRE = "youzan.salesman.account.fire";

        /// <summary>
        /// 获取推广订单列表
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/74"/>
        internal const string SALESMAN_TRADES_GET = "youzan.salesman.trades.get";

        /// <summary>
        /// 获取商品推广链接
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/43"/>
        internal const string SALESMAN_ITEM_SHARE_GET = "youzan.salesman.item.share.get";

        /// <summary>
        /// 获取分销员业绩统计
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/37"/>
        internal const string SALESMAN_ACCOUNT_SCORE_SEARCH = "youzan.salesman.account.score.search";

        /// <summary>
        /// 批量获取商品提成比例信息
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/732"/>
        internal const string SALESMAN_ITEMS_GET = "youzan.salesman.items.get";

        #endregion

        #region 优惠券/码API

        /// <summary>
        /// （分页查询）查询优惠券/码列表
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/159"/>
        internal const string UMP_COUPON_SEARCH = "youzan.ump.coupon.search";

        /// <summary>
        /// 发放优惠券优惠码
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/155"/>
        internal const string UMP_COUPON_TAKE = "youzan.ump.coupon.take";

        /// <summary>
        /// 根据核销码获取优惠券/优惠码
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/142"/>
        internal const string UMP_COUPON_CONSUME_GET = "youzan.ump.coupon.consume.get";

        /// <summary>
        /// 查询买家优惠券列表 查询条件优先级 1. mobile 2. open_user_id 3. fans_id fans_type
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/163"/>
        internal const string UMP_PROMOCRAD_BUYER_SEARCH = "youzan.ump.promocard.buyer.search";

        /// <summary>
        /// 根据凭证状态查询用户凭证列表，
        /// 凭证状态：0.全部1.生效=未使用and未过期2.已使用3.已过期=未使用and已过期4.已失效=已使用or已过期
        /// 其中 1、yz_open_id；2、mobile；3、fans_id和fans_type三组参数中必须要传一个。
        /// （fans_id和fans_type组成一个唯一的有赞用户标识。）
        /// </summary>
        internal const string UMP_VOUCHER_QUERY = "youzan.ump.voucher.query";

        #endregion

        #region 商品API

        /// <summary>
        /// 获取出售中的商品列表，可获取微商城全部商品信息
        /// </summary>
        internal const string ITEMS_ONSALE_GET = "youzan.items.onsale.get";

        /// <summary>
        /// 该接口用于查询单个商品详细信息，需使用对应店铺下的item_id。
        /// 该接口支持微商城零售连锁总部，微商城零售连锁分店，微商城零售连锁单店调用。
        /// </summary>
        internal const string ITEM_GET = "youzan.item.get";

        /// <summary>
        /// 根据编码和商品类型查询查询商品标准
        /// </summary>
        internal const string ITEM_STANDARD_GET = "youzan.item.standard.get";

        #endregion

        #region 交易API

        /// <summary>
        /// youzan.trades.sold.get 订单搜索接口
        /// </summary>
        internal const string TRADES_SOLD_GET = "youzan.trades.sold.get";

        /// <summary>
        /// youzan.trade.memo.update    增加/修改订单备注
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/137"/>
        internal const string TRADE_MEMO_UPDATE = "youzan.trade.memo.update";

        /// <summary>
        /// youzan.trade.star.update 订单标星接口
        /// </summary>
        internal const string TRADE_STAR_UPDATE = "youzan.trade.star.update";

        /// <summary>
        /// youzan.trade.order.out.create 外部订单开单接口
        /// </summary>
        internal const string TRADE_ORDER_OUT_CREATE = "youzan.trade.order.out.create";

        /// <summary>
        /// youzan.trade.get 交易订单详情4.0接口
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/120"/>
        internal const string TRADE_GET = "youzan.trade.get";

        #endregion

        /// <summary>
        /// 给用户加积分，帐号类型(与帐户ID配合使用: 1:粉丝(原fansId),2:手机号,3:三方帐号(原open_user_id),4:UnionID,5:OpenID
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/872"/>
        internal const string CRM_CUSTOMER_POINTS_INCREASE = "youzan.crm.customer.points.increase";

        /// <summary>
        /// 解冻用户积分
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/2673"/>
        internal const string SCRM_CUSTOMER_POINTS_OPERATE_UNFREEZE = "youzan.scrm.customer.points.operate.unfreeze";

        /// <summary>
        /// 给用户加成长值，帐号类型(与帐户ID配合使用: 1:粉丝(原fansId),2:手机号,3:三方帐号(原open_user_id),4:UnionID,5:OpenID
        /// </summary>
        /// <see cref="https://doc.youzanyun.com/detail/API/0/863"/>
        internal const string CRM_CUSTOMER_GROWTH_INCREASE = "youzan.crm.customer.growth.increase";

        #endregion
    }
}