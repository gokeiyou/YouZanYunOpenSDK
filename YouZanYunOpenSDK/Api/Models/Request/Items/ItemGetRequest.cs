using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Items
{
    public class ItemGetRequest :YouZanRequest
    {
        /// <summary>
        /// 有赞连锁网店店铺id，仅供有赞连锁场景下使用。有赞平台生成，在有赞平台唯一，用于判断信息属于哪一个网店。传了返回网店数据。
        /// </summary>
        [ApiField("node_kdt_id")]
        public string NodeKdtId { get; set; }
        /// <summary>
        /// 商品Id，可以通过列表接口如youzan.items.onsale.get （查询出售中商品）和 youzan.items.inventory.get （查询仓库中商品）获取到
        /// </summary>
        [ApiField("item_id")]
        public string ItemId { get; set; }
        /// <summary>
        /// 商品别名，可以通过列表接口如youzan.items.onsale.get （查询出售中商品）和 youzan.items.inventory.get （查询仓库中商品）获取到;item_id和alias二者选一
        /// </summary>
        [ApiField("alias")]
        public string Alias { get; set; }
        /// <summary>
        /// 有赞连锁网店商品id，仅供有赞连锁场景下使用。item_id和node_item_id只能传一个。传了返回网店数据。
        /// </summary>
        [ApiField("node_item_id")]
        public string NodeItemId { get; set; }

    }
}