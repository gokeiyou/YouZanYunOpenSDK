using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace YouZan.Open.DB
{
    public class MySqlDBHelper : IDBHelper
    {

        public T ExecuteSql<T>(string sql, Func<DbCommand, T> func)
        {
            throw new NotImplementedException();
        }

        public T ExecuteSqlWithTran<T>(string sql, Func<DbCommand, T> func)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
