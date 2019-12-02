using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Log;

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

    }
}
