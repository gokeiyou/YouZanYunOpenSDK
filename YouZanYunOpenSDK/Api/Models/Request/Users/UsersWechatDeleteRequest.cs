using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Users
{
    /// <summary>
    /// 删除三方帐号信息，用于App开店帐号一键授权 参数
    /// </summary>
    public class UsersWechatDeleteRequest : YouZanRequest
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        [ApiField("delete_account_bind_for_carmen_dto")]
        public DeleteAccountBindForCarmen DeleteAccountBindForCarmen { get; set; }
    }

    /// <summary>
    /// 删除三方帐号信息，用于App开店帐号一键授权 参数明细
    /// </summary>
    public class DeleteAccountBindForCarmen
    {
        /// <summary>
        /// 验证标识。代表thirdUserId等
        /// </summary>
        [ApiField("open_user_id")]
        public string OpenUserId { get; set; }
        
        /// <summary>
        /// 店铺在有赞的id标识，有赞平台生成，在有赞平台唯一，用于判断信息属于哪一个店铺
        /// </summary>
        [ApiField("kdt_id")]
        public string KdtId { get; set; }
    }
}