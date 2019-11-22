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
    }
}
