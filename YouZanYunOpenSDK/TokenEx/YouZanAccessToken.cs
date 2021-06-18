using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using YouZan.Open.Common.Constant;
using YouZan.Open.Core;
using YouZan.Open.DB;
using static YouZan.Open.TokenEx.OauthToken;

namespace YouZan.Open.TokenEx
{
    public class YouZanAccessToken
    {
        public string Key { get; set; }
        public string TokenData { get; set; }
        public DateTime AddTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; } = null;

        public static TokenData GetData(string key, Func<bool, TokenData> func)
        {
            string tableName;
            string field;
            string condition;
            switch (YouZanConfig.DBType)
            {
                case DBType.Oracle:
                    tableName = $"\"{YouZanConfig.AccessTokenTableName}\"";
                    field = "\"TokenData\"";
                    condition = $"\"Key\" = '{key}'";
                    break;
                case DBType.MySql:
                    tableName = $"`{YouZanConfig.AccessTokenTableName}`";
                    field = "`TokenData`";
                    condition = $"`Key` = '{key}'";
                    break;
                case DBType.SqlServer:
                default:
                    tableName = $"[{YouZanConfig.AccessTokenTableName}]";
                    field = "[TokenData]";
                    condition = $"[Key] = '{key}'";
                    break;
            }

            string SQL = $"SELECT {field} FROM {tableName} WHERE {condition};";

            IDBHelper db = DBFactory.CreateInstance();
            string tokenData = db.ExecuteSql(SQL, cmd => cmd.ExecuteScalar()?.ToString());
            if (string.IsNullOrEmpty(tokenData))
                return func(true);

            var token = JsonConvert.DeserializeObject<TokenData>(tokenData);

            if (token.ExpiresTime <= DateTime.Now)
                return func(false);

            return JsonConvert.DeserializeObject<TokenData>(tokenData);
        }

        public void Save(bool create = true)
        {
            var type = this.GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            string tableName;
            string[] fields = default;
            string[] @params = default;
            DbParameter[] parameters = default;
            string updateField;
            string condition;
            switch (YouZanConfig.DBType)
            {
                case DBType.Oracle:
                    tableName = $"\"{YouZanConfig.AccessTokenTableName}\"";
                    fields = properties.Select(p => $"{p.Name}").ToArray();
                    @params = properties.Select(p => $":{p.Name}").ToArray();
                    updateField = $"TokenData = :TokenData,UpdateTime=SYSDATE";
                    condition = $"Key = :Key";
                    parameters = properties.Select(t => new OracleParameter($":{t.Name}", t.GetValue(this))).ToArray();
                    break;
                case DBType.MySql:
                    tableName = $"`{YouZanConfig.AccessTokenTableName}`";
                    fields = properties.Select(t => $"`{t.Name}`").ToArray();
                    @params = properties.Select(t => $"?{t.Name}").ToArray();
                    updateField = $"`TokenData` = ?TokenData,`UpdateTime`=NOW()";
                    condition = $"`Key` = ?Key";
                    parameters = properties.Select(t => new MySqlParameter($"?{t.Name}", t.GetValue(this))).ToArray();
                    break;
                case DBType.SqlServer:
                default:
                    tableName = $"[{YouZanConfig.AccessTokenTableName}]";
                    fields = properties.Select(t => $"[{t.Name}]").ToArray();
                    @params = properties.Select(t => $"@{t.Name}").ToArray();
                    updateField = $"[TokenData] = @TokenData,[UpdateTime]=GETDATE()";
                    condition = $"[Key] = @Key";
                    parameters = properties.Select(t => new SqlParameter($"@{t.Name}", t.GetValue(this))).ToArray();
                    break;
            }
            string SQL = $"UPDATE {tableName} SET {updateField} WHERE {condition};";
            if (create)
                SQL = $"INSERT INTO {tableName}({string.Join(",", fields)}) VALUES ({string.Join(",", @params)});";

            IDBHelper db = DBFactory.CreateInstance();

            db.ExecuteSql(SQL, cmd => {
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            });
        }
    }
}
