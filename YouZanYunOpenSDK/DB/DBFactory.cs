using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Constant;
using YouZan.Open.Core;
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
            switch (YouZanConfig.DBType)
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
