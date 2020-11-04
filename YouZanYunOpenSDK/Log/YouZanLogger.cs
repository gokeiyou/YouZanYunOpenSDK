using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using YouZan.Open.Common.Constant;
using YouZan.Open.Core;
using YouZan.Open.DB;

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
            string tableName;
            string[] fields = default;
            string[] @params = default;
            DbParameter[] parameters = default;

            switch (YouZanConfig.DBType)
            {
                case DBType.Oracle:
                    tableName = $"\"{YouZanConfig.ApiLogTableName}\"";
                    fields = properties.Select(t => $"{t.Name}").ToArray();
                    @params = properties.Select(t => $":{t.Name}").ToArray();
                    parameters = properties.Select(t => new OracleParameter($":{t.Name}", t.GetValue(this))).ToArray();
                    break;
                case DBType.MySql:
                    tableName = $"`{YouZanConfig.ApiLogTableName}`";
                    fields = properties.Select(t => $"`{t.Name}`").ToArray();
                    @params = properties.Select(t => $"?{t.Name}").ToArray();
                    parameters = properties.Select(t => new MySqlParameter($"?{t.Name}", t.GetValue(this))).ToArray();
                    break;
                case DBType.SqlServer:
                default:
                    tableName = $"[{YouZanConfig.ApiLogTableName}]";
                    fields = properties.Select(t => $"[{t.Name}]").ToArray();
                    @params = properties.Select(t => $"@{t.Name}").ToArray();
                    parameters = properties.Select(t => new SqlParameter($"@{t.Name}", t.GetValue(this))).ToArray();
                    break;
            }

            string SQL = $"INSERT INTO {tableName}({string.Join(",", fields)}) VALUES ({string.Join(",", @params)});";

            IDBHelper db = DBFactory.CreateInstance();

            db.ExecuteSql(SQL, cmd =>
            {
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            });

        }
    }
}
