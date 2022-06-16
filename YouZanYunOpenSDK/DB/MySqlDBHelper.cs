using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using MySql.Data.MySqlClient;
using YouZan.Open.Core;

namespace YouZan.Open.DB
{
    /// <summary>
    /// MySQL 数据库工具类
    /// </summary>
    public class MySqlDBHelper : IDBHelper
    {

        public T ExecuteSql<T>(string sql, Func<DbCommand, T> func)
        {
            using (var conn = new MySqlConnection(YouZanConfig.DBConnectionString))
            {
                try
                {
                    conn.Open();
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;

                    return func.Invoke(cmd);
                }
                catch
                {
                    return default;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
        }

        public T ExecuteSqlWithTran<T>(string sql, Func<DbCommand, T> func)
        {
            using (var conn = new MySqlConnection(YouZanConfig.DBConnectionString))
            {
                MySqlTransaction tran = null;
                try
                {
                    conn.Open();
                    var cmd = conn.CreateCommand();
                    tran = conn.BeginTransaction();
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;

                    T t = func.Invoke(cmd);
                    tran.Commit();
                    return t;
                }
                catch
                {
                    if (tran == null) return default;
                    
                    tran.Rollback();
                    tran.Dispose();
                    return default;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
