using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Constant;

namespace YouZan.Open.Core
{
    public class YouZanConfig
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string DBConnectionString = "";
        /// <summary>
        /// 数据库类型
        /// </summary>
        public static DBType DBType = DBType.SqlServer;
        /// <summary>
        /// 是否保存API日志到数据库
        /// </summary>
        public static bool SaveApiLogToDB = false;
        /// <summary>
        /// API日志表名
        /// </summary>
        public static string ApiLogTableName = "YouZanApiLogs";
        /// <summary>
        /// 是否保存AccessToken到数据库
        /// </summary>
        public static bool SaveAccessTokenToDB = false;
        /// <summary>
        /// AccessToken表名
        /// </summary>
        public static string AccessTokenTableName = "YouZanAccessToken";
    }
}
