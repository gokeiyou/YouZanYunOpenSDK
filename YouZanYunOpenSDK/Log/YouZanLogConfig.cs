using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Log
{
    public class YouZanLogConfig
    {
        public static bool IsDBLog = false;
        public static string DBConnectionString = "";
        public static string LogTableName = "YouZanApiLogs";
        public static YouZanLogDBType DBType = YouZanLogDBType.SqlServer;
    }

    public enum YouZanLogDBType
    {
        SqlServer,
        Oracle,
        MySql,
    }
}
