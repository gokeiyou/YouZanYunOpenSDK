namespace YouZan.Open.Api.Constant
{
    /// <summary>
    /// 性别
    /// </summary>
    public enum YzGender
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
    public enum WeixinOpenIdType
    {
        /// <summary>
        /// 微信公众号
        /// </summary>
        WEIXIN_MP = 1,
        /// <summary>
        /// 微信小程序
        /// </summary>
        WEIXIN_MINI_PROGRAM = 2,
        /// <summary>
        /// 微信大账号
        /// </summary>
        BIG_ACCOUNT = 9
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
        WeixinMp,
        /// <summary>
        /// 手机帐号
        /// </summary>
        WeixinMiniprogram,
        /// <summary>
        /// 微信大账号
        /// </summary>
        WeixinBigAccount = 9
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
        Miniprogram
    }
}
