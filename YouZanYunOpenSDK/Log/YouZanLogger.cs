﻿using System;
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
        public string ClientId { get; set; }
        public string GrantId { get; set; }
        private DateTime LogTime { get; set; }
        public string ApiName { get; set; }
        public string ApiVersion { get; set; }
        public string ApiMethod { get; set; }
        public string AuthType { get; set; }
        public string RequestUrl { get; set; }
        public string Header { get; set; }
        public string PostData { get; set; }
        public string ResponseData { get; set; }

        private static readonly IDBHelper Db = DBFactory.DbHelper;

        public void Save()
        {
            Guid = System.Guid.NewGuid().ToString("N");
            LogTime = DateTime.Now;
            var type = GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            string tableName;
            string[] fields;
            string[] @params;
            DbParameter[] parameters;

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

            var sql = $"INSERT INTO {tableName}({string.Join(",", fields)}) VALUES ({string.Join(",", @params)});";
            
            Db.ExecuteSql(sql, cmd =>
            {
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            });

        }
    }
}
