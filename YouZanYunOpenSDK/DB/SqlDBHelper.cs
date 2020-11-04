using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using YouZan.Open.Core;
using YouZan.Open.Log;

namespace YouZan.Open.DB
{
    public class SqlDBHelper : IDBHelper
    {

        public T ExecuteSql<T>(string sql, Func<DbCommand, T> func)
        {
            using (SqlConnection conn = new SqlConnection(YouZanConfig.DBConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
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
            using (SqlConnection conn = new SqlConnection(YouZanConfig.DBConnectionString))
            {
                SqlTransaction tran = null;
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
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
