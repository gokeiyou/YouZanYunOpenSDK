using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouZan.Open.Api.Entry.Response.Trade
{
    /// <summary>
    /// 订单详情实体（未完全）
    /// </summary>
    public class TradeGetResponse
    {
        [JsonProperty("full_order_info")]
        public FullOrderInfo FullOrderInfo { get; set; }

        [JsonProperty("delivery_order")]
        public List<DeliveryOrder> DeliveryOrder { get; set; }

        [JsonProperty("order_promotion")]
        public OrderPromotion OrderPromotion { get; set; }

        [JsonProperty("refund_order")]
        public List<RefundOrder> RefundOrder { get; set; }

    }

    public class RefundOrder
    {
        //public string RefundOrderJson { get; set; }
    }

    public class OrderPromotion
    {
        //public string RefundOrderJson { get; set; }
    }


    #region DeliveryOrder
    public class DeliveryOrder
    {
        /// <summary>
        /// 包裹id该字段已废弃， 请使用dists中的dist_id字段
        /// </summary>
        [JsonProperty("pk_id")]
        public string PkId { get; set; }

        /// <summary>
        /// 物流状态 0:待发货; 1:已发货
        /// </summary>
        [JsonProperty("express_state")]
        public int ExpressState { get; set; }

        /// <summary>
        /// 物流
        /// </summary>
        [JsonProperty("dists")]
        public List<Dists> Dists { get; set; }

        /// <summary>
        /// 发货方式。 0:手动发货（商城后台人工发货），1:接口发货（有赞云发货API发货）
        /// </summary>
        [JsonProperty("express_type")]
        public string ExpressType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("oids")]
        public List<Oids> Oids { get; set; }

    }

    public class Dists
    {
        [JsonProperty("dist_items")]
        public Oids DistItems { get; set; }

        [JsonProperty("express_info")]
        public ExpressInfo ExpressInfo { get; set; }
        
    }

    public class ExpressInfo
    {
        [JsonProperty("express_id")]
        public string ExpressId { get; set; }

        [JsonProperty("express_no")]
        public string ExpressNo { get; set; }
    }

    public class Oids
    {
        [JsonProperty("oid")]
        public string Oid { get; set; }
    }

    #endregion

    #region FullOrderInfo

    /// <summary>
    /// FullOrderInfo（未完）
    /// </summary>
    public class FullOrderInfo
    {
        [JsonProperty("orders")]
        public List<Order> Orders { get; set; }

        [JsonProperty("address_info")]
        public AddressInfo AddressInfo { get; set; }

        [JsonProperty("pay_info")]
        public PayInfo PayInfo { get; set; }

        [JsonProperty("order_info")]
        public OrderInfo OrderInfo { get; set; }

        [JsonProperty("child_info")]
        public string ChildInfo { get; set; }

        [JsonProperty("source_info")]
        public string SourceInfo { get; set; }

        [JsonProperty("remark_info")]
        public RemarkInfo RemarkInfo { get; set; }

        [JsonProperty("invoice_info")]
        public string InvoiceInfo { get; set; }

        [JsonProperty("buyer_info")]
        public string BuyerInfo { get; set; }

    }

    #region 二级实体参数

    public class OrderInfo
    {
        [JsonProperty("order_extra")]
        public OrderExtra OrderExtra { get; set; }

        [JsonProperty("order_tags")]
        public OrderTags OrderTags { get; set; }

        /// <summary>
        /// 配送方式（物流类型）， 0:快递发货; 1:到店自提; 2:同城配送; 9:无需发货（虚拟商品订单）
        /// </summary>
        [JsonProperty("express_type")]
        public int ExpressType { get; set; }
        /// <summary>
        /// 交易完成时间，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
        /// </summary>
        [JsonProperty("success_time")]
        public DateTime SuccessTime { get; set; }
        /// <summary>
        /// 主订单状态描述，和status对应关系。
        /// WAIT_BUYER_PAY：待支付，TRADE_PAID：已支付，WAIT_CONFIRM：待接单， WAIT_SELLER_SEND_GOODS：待发货，WAIT_BUYER_CONFIRM_GOODS：已发货，TRADE_SUCCESS：已完成，TRADE_CLOSED：已关闭
        /// </summary>
        [JsonProperty("status_str")]
        public string StatusStr { get; set; }

        /// <summary>
        /// 主订单状态：
        /// WAIT_BUYER_PAY：等待买家付款，定金预售描述：定金待付、等待尾款支付开始、尾款待付， TRADE_PAID：订单已支付 ，该状态仅代表当前订单已支付成功，表示瞬时状态，稍后会自动修改成后面的状态。如果不关心此状态请再次请求详情接口获取下一个状态， WAIT_CONFIRM：待确认，包含待成团、待接单等等。即：买家已付款，等待成团或等待接单， WAIT_SELLER_SEND_GOODS：等待卖家发货，即：买家已付款， WAIT_BUYER_CONFIRM_GOODS 等待买家确认收货，即：卖家已发货， TRADE_SUCCESS：买家已签收以及订单成功， TRADE_CLOSED：交易关闭
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 有赞订单号，E开头长度24位字母和数字组合
        /// </summary>
        [JsonProperty("tid")]
        public string Tid { get; set; }
        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("node_kdt_id")]
        public string NodeKdtId { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; set; }
        /// <summary>
        /// 是否零售订单，true：是，false：否
        /// </summary>
        [JsonProperty("is_retail_order")]
        public bool IsRetailOrder { get; set; }
        /// <summary>
        /// 退款状态 0:未退款， 1:部分退款中，2:部分退款成功， 11:全额退款中， 12:全额退款成功。
        /// </summary>
        [JsonProperty("refund_state")]
        public int RefundState { get; set; }
        /// <summary>
        /// 总店id
        /// </summary>
        [JsonProperty("root_kdt_id")]
        public string RootKdtId { get; set; }
        /// <summary>
        /// 订单更新时间
        /// </summary>
        [JsonProperty("update_time")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 订单支付类型
        /// 0:默认值, 未支付; 1:微信自有支付; 2:支付宝wap; 3:支付宝wap; 5:财付通; 7:代付; 8:联动优势; 9:货到付款; 10:大账号代销; 11:受理模式; 12:百付宝; 13:sdk支付; 14:合并付货款; 15:赠品; 16:优惠兑换; 17:自动付货款; 18:爱学贷; 19:微信wap; 20:微信红包支付; 21:返利; 22:ump红包; 24:易宝支付; 25:储值卡; 27:qq支付; 28:有赞E卡支付; 29:微信条码; 30:支付宝条码; 33:礼品卡支付; 35:储值卡（会员余额）; 37:银行卡支付;72:微信扫码二维码支付; 100:代收账户; 300:储值账户; 400:保证金账户; 101:收款码; 102:微信; 103:支付宝; 104:刷卡; 105:二维码台卡; 106:储值卡（线下场景使用）; 107:有赞E卡; 110:标记收款-自有微信支付; 111:标记收款-自有支付宝; 112:标记收款-自有POS刷卡; 113:通联刷卡支付; 200:记账账户; 201:现金;202:组合支付
        /// </summary>
        [JsonProperty("pay_type")]
        public int PayType { get; set; }
        /// <summary>
        /// 多人拼团成功时间（仅限多人拼团使用），其他类型返回为空，
        /// </summary>
        [JsonProperty("confirm_time")]
        public DateTime? ConfirmTime { get; set; }
        /// <summary>
        /// 主订单类型
        /// 0:普通订单; 1:送礼订单; 2:代付; 3:分销采购单; 4:赠品; 5:心愿单; 6:二维码订单; 7:合并付货款; 8:1分钱实名认证; 9:品鉴; 10:拼团; 15:返利; 35:酒店; 40:外卖; 41:堂食点餐; 46:外卖买单; 51:全员开店; 61:线下收银台订单; 71:美业预约单; 72:美业服务单; 75:知识付费; 81:礼品卡; 100:批发
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// 订单支付时间
        /// </summary>
        [JsonProperty("pay_time")]
        public DateTime PayTime { get; set; }
        /// <summary>
        /// 订单关闭类型
        ///  0:未关闭; 1:过期关闭; 2:标记退款; 3:订单取消; 4:买家取消; 5:卖家取消; 6:部分退款; 10:无法联系上买家; 11:买家误拍或重拍了; 12:买家无诚意完成交易; 13:已通过银行线下汇款; 14:已通过同城见面交易; 15:已通过货到付款交易; 16:已通过网上银行直接汇款; 17:已经缺货无法交易; 18:扣款失败; 19:0元关单; 20:社区团购活动结束未付款; 21:0元抽奖订单未中一等奖; 22:拒单退款;
        /// </summary>
        [JsonProperty("close_type")]
        public int CloseType { get; set; }
        /// <summary>
        /// 支付渠道
        /// 取值范围： WEIXIN:微信自有支付, WEIXIN_DAIXIAO :微信代销支付, ALIPAY :支付宝支付, BANKCARDPAY:银行卡支付, PEERPAY :代付, CODPAY :货到付款),BAIDUPAY :百度钱包支付, PRESENTTAKE :直接领取赠品, COUPONPAY:优惠券/码全额抵扣, BULKPURCHASE:来自分销商的采购, MERGEDPAY:合并付货款, ECARD:有赞E卡支付, PURCHASE_PAY :采购单支付, MARKPAY :标记收款, OFCASH :现金支付, PREPAIDCARD :储值卡余额支付，ENCHASHMENT_GIFT_CARD:礼品卡支付
        /// </summary>
        [JsonProperty("pay_type_str")]
        public string PayTypeStr { get; set; }
        /// <summary>
        /// 多网点id，非多网点订单，该字段不返回。
        /// </summary>
        [JsonProperty("offline_id")]
        public string OfflineId { get; set; }

        /// <summary>
        /// 活动类型
        /// 0: "没有活动",1: "没有活动", 2: "团购返现",3: "降价拍",4: "拼团",5: "积分兑换",6: "秒杀",7: "优惠套餐",8: "赠品",9: "商品扫码",10: "会员折扣",11: "限时折扣",12: "众筹",13:"周期购",14: "送礼",15: "随机点餐",16: "扫码优惠",19: "享立减",20: "F码",21: "助力砍价",22: "推荐有奖",23: "抽奖拼团",24: "加价购",63: "送礼社区版",101: "满减送",102: "订单返现",103: "供货商满包邮",114: "定金膨胀",115: "第二件半价",256:"积分抵现"
        /// </summary>
        [JsonProperty("activity_type")]
        [Obsolete]
        public int ActivityType { get; set; }
        /// <summary>
        /// 订单过期时间（未付款订单关闭时间）
        /// </summary>
        [JsonProperty("expired_time")]
        public int ExpiredTime { get; set; }
        /// <summary>
        /// 订单发货时间（当所有商品发货后才会更新）
        /// </summary>
        [JsonProperty("consign_time")]
        public DateTime ConsignTime { get; set; }

        /// <summary>
        /// 店铺类型
        /// 0:微商城; 1:微小店; 2:爱学贷微商城; 3:批发店铺; 4:批发商城; 5:外卖; 6:美业; 7:超级门店; 8:收银; 9:收银加微商城; 10:零售总部; 99:有赞开放平台平台型应用创建的店铺
        /// </summary>
        [JsonProperty("team_type")]
        public int TeamType { get; set; }
    }

    /// <summary>
    /// 备注信息
    /// </summary>
    public class RemarkInfo
    {
        /// <summary>
        /// 订单卖家备注
        /// </summary>
        [JsonProperty("trade_memo")]
        public string TradeMemo { get; set; }

        /// <summary>
        /// 订单标星等级： 0~5分别表示不同星级。
        /// </summary>
        [JsonProperty("star")]
        public int Star { get; set; }

        /// <summary>
        /// 订单买家留言
        /// </summary>
        [JsonProperty("buyer_message")]
        public string BuyerMessage { get; set; }

    }

    #endregion

    #region 三级参数

    /// <summary>
    /// 订单信息
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 商品id，有赞生成的商品唯一值。
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 订单商品扩展信息
        /// </summary>
        [JsonProperty("order_item_extra")]
        public string[] OrderItemExtra { get; set; }
        /// <summary>
        /// 分销单实付金额 ，单位元
        /// </summary>
        [JsonProperty("fenxiao_payment")]
        public string FenxiaoPayment { get; set; }
        /// <summary>
        /// 海淘-申报单价（完税价格）, 单位：元
        /// </summary>
        [JsonProperty("goods_dutiable_price")]
        public string GoodsDutiablePrice { get; set; }
        /// <summary>
        /// 税费，单位：元
        /// </summary>
        [JsonProperty("tax_total")]
        public string TaxTotal { get; set; }
        /// <summary>
        /// 是否为预售商品，是：返回为1，否返回为空
        /// </summary>
        [JsonProperty("is_pre_sale")]
        public string IsPreSale { get; set; }
        /// <summary>
        /// 商品留言
        /// </summary>
        [JsonProperty("buyer_messages")]
        public string BuyerMessages { get; set; }
        /// <summary>
        /// 单商品原价，单位：元
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// 海淘商品贸易模式，BC直邮：9610，BBC保税进口：1210
        /// </summary>
        [JsonProperty("cross_border_trade_mode")]
        public string CrossBorderTradeMode { get; set; }
        /// <summary>
        /// 运杂费(仅海淘订单有该字段返回)，单位：元
        /// </summary>
        [JsonProperty("freight")]
        public string Freight { get; set; }
        /// <summary>
        /// 订单明细id
        /// </summary>
        [JsonProperty("oid")]
        public string Oid { get; set; }
        /// <summary>
        /// 订单明细应付金额，订单上每个商品最终均摊价，单位：元
        /// </summary>
        [JsonProperty("payment")]
        public string Payment { get; set; }
        /// <summary>
        /// 分销商品金额, 单位：元
        /// </summary>
        [JsonProperty("fenxiao_discount_price")]
        public string FenxiaoDiscountPrice { get; set; }
        /// <summary>
        /// 是否赠品，是：true，否：false
        /// </summary>
        [JsonProperty("is_present")]
        public bool IsPresent { get; set; }

        /// <summary>
        /// 是否是跨境海淘订单，是：返回为1，否返回为空
        /// </summary>
        [JsonProperty("is_cross_border")]
        public string IsCrossBorder { get; set; }

        /// <summary>
        /// 分销海淘 - 商品总货值（完税价格* 商品数量），单位：元
        /// </summary>
        [JsonProperty("fenxiao_goods_total_dutiable_price")]
        public string FenxiaoGoodsTotalDutiablePrice { get; set; }

        /// <summary>
        /// 订单类型 0:普通类型商品; 1:拍卖商品; 5:餐饮商品; 10:分销商品; 20:会员卡商品; 21:礼品卡商品; 23:有赞会议商品; 24:周期购; 30:收银台商品; 31:知识付费商品; 35:酒店商品; 40:普通服务类商品; 182:普通虚拟商品; 183:电子卡券商品; 201:外部会员卡商品; 202:外部直接收款商品; 203:外部普通商品; 205:mock不存在商品; 206:小程序二维码
        /// </summary>
        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 商品编码，商家自定义编码，可用于和其他系统之间商品的外部id的标识。
        /// </summary>
        [JsonProperty("outer_item_id")]
        public string OuterItemId { get; set; }

        /// <summary>
        /// 商品规格编码，sku_id值不为0时：返回商品规格编码；sku_id值为0时：当设置商品编码后且开启多网点功能，返回值为商品编码，否则返回空。
        /// </summary>
        [JsonProperty("outer_sku_id")]
        public string OuterSkuId { get; set; }
        /// <summary>
        /// 商品总价（扣除商品级优惠） 单位：元
        /// </summary>
        [JsonProperty("total_fee")]
        public string TotalFee { get; set; }
        /// <summary>
        /// 海淘订单子订单号
        /// </summary>
        [JsonProperty("sub_order_no")]
        public string SubOrderNo { get; set; }
        /// <summary>
        /// 商品规格id，有赞生成的规格id。无规格商品返回0
        /// </summary>
        [JsonProperty("sku_id")]
        public int SkuId { get; set; }
        /// <summary>
        /// 分销税费, 单位：元
        /// </summary>
        [JsonProperty("fenxiao_tax_total")]
        public string FenxiaoTaxTotal { get; set; }
        /// <summary>
        /// 海淘 - 商品总货值（完税价格* 商品数量），单位：元
        /// </summary>
        [JsonProperty("goods_total_dutiable_price")]
        public string GoodsTotalDutiablePrice { get; set; }
        /// <summary>
        /// 海淘 - 虚拟货币优惠金额（积分、优惠券），单位：元
        /// </summary>
        [JsonProperty("virtual_currency")]
        public string VirtualCurrency { get; set; }
        /// <summary>
        /// 海淘 - 促销优惠金额（不含虚拟货币优惠金额），单位：元
        /// </summary>
        [JsonProperty("promotion_discount")]
        public string PromotionDiscount { get; set; }
        /// <summary>
        /// 商品唯一编码
        /// </summary>
        [JsonProperty("sku_unique_code")]
        public string SkuUniqueCode { get; set; }
        /// <summary>
        /// 分销非现金抵扣金额, 单位：元
        /// </summary>
        [JsonProperty("fenxiao_discount")]
        public string FenxiaoDiscount { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("num")]
        public int Num { get; set; }
        /// <summary>
        /// 商品图片地址
        /// </summary>
        [JsonProperty("pic_path")]
        public string PicPath { get; set; }
        /// <summary>
        /// 0 全款预售，1 定金预售
        /// </summary>
        [JsonProperty("pre_sale_type")]
        public string PreSaleType { get; set; }
        /// <summary>
        /// 海关编号，更多海关编码请访问：详见文档
        /// </summary>
        [JsonProperty("customs_code")]
        public string CustomsCode { get; set; }

        /// <summary>
        /// 分销运费, 单位：元
        /// </summary>
        [JsonProperty("fenxiao_freight")]
        public string FenxiaoFreight { get; set; }
        /// <summary>
        /// 商品别名
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }
        /// <summary>
        /// 商品详情链接
        /// </summary>
        [JsonProperty("goods_url")]
        public string GoodsUrl { get; set; }
        /// <summary>
        /// 单商品现价，减去了商品的优惠金额。单位：元
        /// </summary>
        [JsonProperty("discount_price")]
        public string DiscountPrice { get; set; }

        /// <summary>
        /// 商品积分价（非积分商品则为0），如返回值是100则表示100积分。
        /// </summary>
        [JsonProperty("points_price")]
        public string PointsPrice { get; set; }

        /// <summary>
        /// 商品规格信息（无规格商品为空）
        /// </summary>
        [JsonProperty("sku_properties_name")]
        public string SkuPropertiesName { get; set; }

        /// <summary>
        /// 商品重量 单位是 g
        /// </summary>
        [JsonProperty("weight")]
        public string Weight { get; set; }
        /// <summary>
        /// 分销单金额 ，单位元
        /// </summary>
        [JsonProperty("fenxiao_price")]
        public string FenxiaoPrice { get; set; }

    }

    public class AddressInfo
    {

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("delivery_province")]
        public string DeliveryProvince { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("delivery_city")]
        public string DeliveryCity { get; set; }


        /// <summary>
        /// 区
        /// </summary>
        [JsonProperty("delivery_district")]
        public string DeliveryDistrict { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonProperty("delivery_address")]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// 到店自提信息 json格式，字段说明请参考：详见文档
        /// </summary>
        [JsonProperty("self_fetch_info")]
        public string SelfFetchInfo { get; set; }

        /// <summary>
        /// 字段为json格式，字段说明请参考：详见文档
        /// </summary>
        [JsonProperty("address_extra")]
        public string AddressExtra { get; set; }


        /// <summary>
        /// 同城送预计送达时间 - 开始时间
        /// </summary>
        [JsonProperty("delivery_start_time")]
        public DateTime DeliveryStartTime { get; set; }

        /// <summary>
        /// 同城送预计送达时间 - 结束时间
        /// </summary>
        [JsonProperty("delivery_end_time")]
        public DateTime DeliveryEndTime { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [JsonProperty("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [JsonProperty("receiver_tel")]
        public string ReceiverTel { get; set; }

        /// <summary>
        /// 邮政编码，当买家使用微信地址时会有值，其它场景可能没有该值，建议不做强依赖。
        /// </summary>
        [JsonProperty("delivery_postal_code")]
        public string DeliveryPostalCode { get; set; }

    }

    public class PayInfo
    {
        [JsonProperty("phase_payments")]
        public PhasePayments PhasePayments { get; set; }

        /// <summary>
        /// 订单整单实付价格 单位：元
        /// </summary>
        [JsonProperty("real_payment")]
        public string RealPayment { get; set; }
        /// <summary>
        /// 商品总价，单位元
        /// </summary>
        [JsonProperty("total_fee")]
        public string TotalFee { get; set; }
        /// <summary>
        /// 订单整单应付金额，单位：元
        /// </summary>
        [JsonProperty("payment")]
        public string Payment { get; set; }
        /// <summary>
        /// 支付流水号（即微信端商户单号）
        /// </summary>
        [JsonProperty("transaction")]
        public string Transaction { get; set; }
        /// <summary>
        /// 邮费，单位元
        /// </summary>
        [JsonProperty("post_fee")]
        public string PostFee { get; set; }
        /// <summary>
        /// 外部订单号（即微信端交易单号）
        /// </summary>
        [JsonProperty("outer_transactions")]
        public List<string> OuterTransactions { get; set; }

        /// <summary>
        /// 礼品卡/储值卡抵扣之后的订单实付金额 单位：分
        /// </summary>
        [JsonProperty("deduction_real_pay")]
        public long DeductionRealPay { get; set; }

        /// <summary>
        /// 礼品卡/储值卡具体抵扣的金额，单位：分
        /// </summary>
        [JsonProperty("deduction_pay")]
        public long DeductionPay { get; set; }


    }

    public class PhasePayments
    {
        /// <summary>
        /// 内部支付流水号
        /// </summary>
        [JsonProperty("inner_transaction_no")]
        public long InnerTransactionNo { get; set; }

        /// <summary>
        /// 支付开始时间
        /// </summary>
        [JsonProperty("pay_start_time")]
        public DateTime PayStartTime { get; set; }
        /// <summary>
        /// 支付类型
        /// 取值范围： WEIXIN (微信自有支付) WEIXIN_DAIXIAO (微信代销支付) ALIPAY (支付宝支付) BANKCARDPAY (银行卡支付) PEERPAY (代付) CODPAY (货到付款) BAIDUPAY (百度钱包支付) PRESENTTAKE (直接领取赠品) COUPONPAY(优惠券/码全额抵扣) BULKPURCHASE(来自分销商的采购) MERGEDPAY(合并付货款) ECARD(有赞E卡支付) PURCHASE_PAY(采购单支付) MARKPAY(标记收款) OFCASH(现金支付) PREPAIDCARD(储值卡余额支付)ENCHASHMENT_GIFT_CARD(礼品卡支付)
        /// </summary>
        [JsonProperty("pay_way_str")]
        public string PayWayStr { get; set; }

        /// <summary>
        /// 支付阶段  1表示第一支付阶段，如定金预售的付定金阶段，2表示第二支付阶段，如定金预售的付尾款
        /// </summary>
        [JsonProperty("phase")]
        public int Phase { get; set; }

        /// <summary>
        /// 阶段支付应付金额，单位元
        /// </summary>
        [JsonProperty("real_price")]
        public string RealPrice { get; set; }

        /// <summary>
        /// 支付结束时间
        /// </summary>
        [JsonProperty("pay_end_time")]
        public DateTime PayEndTime { get; set; }

        /// <summary>
        /// 外部支付流水号
        /// </summary>
        [JsonProperty("outer_transaction_no")]
        public string OuterTransactionNo { get; set; }

    }

    /// <summary>
    /// 未完
    /// </summary>
    public class OrderExtra
    {
    }

    /// <summary>
    /// 未完
    /// </summary>
    public class OrderTags
    {
    } 
    #endregion

    #endregion

}