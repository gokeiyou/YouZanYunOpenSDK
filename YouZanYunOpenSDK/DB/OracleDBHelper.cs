using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using YouZan.Open.Log;

namespace YouZan.Open.DB
{
    public class OracleDBHelper : IDBHelper
    {
        public T ExecuteSql<T>(string sql, Func<DbCommand, T> func)
        {
            using (OracleConnection conn = new OracleConnection(YouZanLogConfig.DBConnectionString))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;

                    return func.Invoke(cmd);
                }
                catch (Exception ex)
                {
                    return default;
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
        }

        public T ExecuteSqlWithTran<T>(string sql, Func<DbCommand, T> func)
        {
            using (OracleConnection conn = new OracleConnection(YouZanLogConfig.DBConnectionString))
            {
                OracleTransaction tran = null;
                try
                {
                    conn.Open();
                    OracleCommand cmd = conn.CreateCommand();
                    tran = conn.BeginTransaction();
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;

                    T t = func.Invoke(cmd);
                    tran.Commit();
                    return t;
                }
                catch (Exception ex)
                {
                    if (tran != null)
                    {
                        tran.Rollback();
                        tran.Dispose();
                    }
                    return default;
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
