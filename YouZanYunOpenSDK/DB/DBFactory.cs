using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Constant;
using YouZan.Open.Log;
using YouZan.Open.TokenEx;

namespace YouZan.Open.DB
{
    public class DBFactory
    {
        /// <summary>
        /// 创建DBHelper
        /// </summary>
        /// <returns></returns>
        public static IDBHelper CreateInstance()
        {
            switch (YouZanLogConfig.DBType)
            {
                case YouZanLogDBType.Oracle:
                    return new OracleDBHelper();
                case YouZanLogDBType.MySql:
                    return new MySqlDBHelper();
                case YouZanLogDBType.SqlServer:
                default:
                    return new SqlDBHelper();
            }
        }

        public static IDBHelper CreateInstanceForToken()
        {
            switch (YouZanTokenConfig.DBType)
            {
                case DBType.Oracle:
                    return new OracleDBHelper();
                case DBType.MySql:
                    return new MySqlDBHelper();
                case DBType.SqlServer:
                default:
                    return new SqlDBHelper();
            }
        }

    }
}
