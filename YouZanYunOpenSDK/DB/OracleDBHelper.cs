using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using YouZan.Open.Core;
using YouZan.Open.Log;

namespace YouZan.Open.DB
{
    public class OracleDBHelper : IDBHelper
    {
        public T ExecuteSql<T>(string sql, Func<DbCommand, T> func)
        {
            using (var conn = new OracleConnection(YouZanConfig.DBConnectionString))
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
            using (var conn = new OracleConnection(YouZanConfig.DBConnectionString))
            {
                OracleTransaction tran = null;
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
