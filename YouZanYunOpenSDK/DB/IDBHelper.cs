using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace YouZan.Open.DB
{
    public interface IDBHelper : IDisposable
    {
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <typeparam name="T">返回值类型</typeparam>
        /// <param name="sql">需要执行的SQL语句</param>
        /// <param name="func">执行过程的委托</param>
        /// <returns></returns>
        T ExecuteSql<T>(string sql, Func<DbCommand, T> func);

        /// <summary>
        /// 执行SQL语句，事务
        /// </summary>
        /// <typeparam name="T">返回值类型</typeparam>
        /// <param name="sql">需要执行的SQL语句</param>
        /// <param name="func">执行过程的委托</param>
        /// <returns></returns>
        T ExecuteSqlWithTran<T>(string sql, Func<DbCommand, T> func);

    }
}
