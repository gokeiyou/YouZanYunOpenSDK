using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using YouZan.Open.Common.Constant;

namespace YouZan.Open.Log
{
    public class YouZanLogger
    {
        private string Guid { get; set; }
        private DateTime LogTime { get; set; }
        public string ApiName { get; set; }
        public string ApiVersion { get; set; }
        public string ApiMethod { get; set; }
        public string AuthType { get; set; }
        public string RequestUrl { get; set; }
        public string Header { get; set; }
        public string PostData { get; set; }
        public string ResponseData { get; set; }

        public void Save()
        {
            this.Guid = System.Guid.NewGuid().ToString("N");
            this.LogTime = DateTime.Now;
            Type type = this.GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            string[] fields = properties.Select(t => $"[{t.Name}]").ToArray();
            string[] @params = properties.Select(t => $"@{t.Name}").ToArray();
            SqlParameter[] parameters = properties.Select(t => new SqlParameter($"@{t.Name}", t.GetValue(this))).ToArray();

            string SQL = $"INSERT INTO {YouZanLogConfig.LogTableName}({string.Join(",", fields)}) VALUES ({string.Join(",", @params)});";

            DbHelper.ExecuteSql(SQL, cmd =>
            {
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            });

        }
    }
}
