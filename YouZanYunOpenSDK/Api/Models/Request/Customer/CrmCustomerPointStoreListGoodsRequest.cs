using System.Collections.Generic;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 积分商城兑换商品查询接口 请求参数
    /// </summary>
    public class CrmCustomerPointStoreListGoodsRequest : YouZanRequest
    {
        /// <summary>
        /// 积分商品类型。1-普通商品，2-优惠券/码，3-权益卡
        /// </summary>
        [ApiField("goods_type_list")]
        public List<int> GoodsTypeList { get; set; }
        
        /// <summary>
        /// 是否过滤有sku的积分商品默认不过滤
        /// </summary>
        [ApiField("without_point_goods_has_sku")]
        public bool WithoutPointGoodsHasSku { get; set; }
        
        /// <summary>
        /// 创建结束时间，时间戳格式，单位秒
        /// </summary>
        [ApiField("created_end")]
        public long CreatedEnd { get; set; }
        
        /// <summary>
        /// 积分价格区间，起始积分；
        /// 当goods_type_list=2或3时，point_price_start和point_price_end才会生效。
        /// goods_type_list=1时point_price_start和point_price_end不生效。
        /// </summary>
        [ApiField("point_price_start")]
        public int PointPriceStart { get; set; }
        
        /// <summary>
        /// 积分价格区间，结束积分；
        /// 当goods_type_list=2或3时，point_price_start和point_price_end才会生效。
        /// goods_type_list=1时point_price_start和point_price_end不生效。
        /// </summary>
        [ApiField("point_price_end")]
        public int PointPriceEnd { get; set; }
        
        /// <summary>
        /// 积分商品状态，默认返回全部状态。1-未开始，2-进行中，3-已结束，4-已失效，0-全部状态
        /// </summary>
        [ApiField("state")]
        public int State { get; set; }
        
        /// <summary>
        /// 商品渠道。0-网点，1-门店
        /// </summary>
        [ApiField("goods_channel")]
        public int GoodsChannel { get; set; }
        
        /// <summary>
        /// 页码，从1~100开始，分页数不能超过100页，不传入默认为1
        /// </summary>
        [ApiField("page")]
        public int Page { get; set; }
        
        /// <summary>
        /// 排序规则, 不传默认按照0-开始时间降序。0-开始时间降序，1-结束时间升序
        /// </summary>
        [ApiField("sort_code")]
        public int SortCode { get; set; }
        
        /// <summary>
        /// 每页条数。不传入或超过100默认为100
        /// </summary>
        [ApiField("page_size")]
        public int PageSize { get; set; }
        
        /// <summary>
        /// 创建起始时间，时间戳格式，单位秒
        /// </summary>
        [ApiField("created_start")]
        public long CreatedStart { get; set; }
    }
}