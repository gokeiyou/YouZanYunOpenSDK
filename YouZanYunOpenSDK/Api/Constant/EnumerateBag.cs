namespace YouZan.Open.Api.Constant
{
    /// <summary>
    /// 性别
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// 未知
        /// </summary>
        Unknown,
        /// <summary>
        /// 男
        /// </summary>
        Male,
        /// <summary>
        /// 女
        /// </summary>
        Female
    }
    /// <summary>
    /// weixin_open_id类型
    /// </summary>
    public enum WeiXinOpenIdType
    {
        /// <summary>
        /// 微信公众号
        /// </summary>
        WeiXinMp = 1,
        /// <summary>
        /// 微信小程序
        /// </summary>
        WeiXinMiniProgram = 2,
        /// <summary>
        /// 微信大账号
        /// </summary>
        BigAccount = 9
    }

    /// <summary>
    /// 
    /// </summary>
    public enum UsersInfoQueryResultType
    {
        /// <summary>
        /// 手机帐号
        /// </summary>
        Mobile,
        /// <summary>
        /// 手机帐号
        /// </summary>
        WeiXinMp,
        /// <summary>
        /// 手机帐号
        /// </summary>
        WeiXinMiniProgram,
        /// <summary>
        /// 微信大账号
        /// </summary>
        WeiXinBigAccount = 9
    }

    /// <summary>
    /// 账号类型
    /// </summary>
    public enum WechatType
    {
        /// <summary>
        /// 公众号
        /// </summary>
        Mp,
        /// <summary>
        /// 小程序
        /// </summary>
        MiniProgram
    }
}
