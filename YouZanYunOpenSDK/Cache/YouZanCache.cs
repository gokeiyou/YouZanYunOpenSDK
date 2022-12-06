using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YouZan.Open.Cache
{
    /// <summary>
    /// 
    /// </summary>
    public class YouZanCache : ICache
    {

        private static readonly IDictionary<string, KeyValuePair<DateTime, object>> CustomerCacheDictionary = new ConcurrentDictionary<string, KeyValuePair<DateTime, object>>();

        static YouZanCache()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    if (CustomerCacheDictionary.Count > 0)
                    {
                        var list = new List<string>();
                        foreach (var item in CustomerCacheDictionary)
                        {
                            var keyValuePair = item.Value;
                            if (DateTime.Now > keyValuePair.Key)//过期了
                            {
                                list.Add(item.Key);
                            }
                        }
                        foreach (var key in list)
                        {
                            CustomerCacheDictionary.Remove(key);
                        }
                    }
                    Thread.Sleep(1000);
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="cacheTime">默认30分钟  单位分钟</param>
        public void Add(string key, object data, int cacheTime = 9900)
        {
            if (CustomerCacheDictionary.ContainsKey(key)) return;
            //throw new Exception("相同的key");
            //_CustomerCacheDictionary.Add(key, new KeyValuePair<DateTime, object>(DateTime.Now.AddMinutes(cacheTime), data));
            this.Add(key, data, DateTime.Now.AddMinutes(cacheTime));
        }

        public void Add(string key, object data, DateTime expires)
        {
            CustomerCacheDictionary.Add(key, new KeyValuePair<DateTime, object>(expires, data));
        }

        /// <summary>
        /// 应该先检查，再get
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T Get<T>(string key)
        {
            return (T)CustomerCacheDictionary[key].Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contains(string key)
        {
            //完成清理  不能用
            //return _CustomerCacheDictionary.ContainsKey(key) && DateTime.Now <= _CustomerCacheDictionary[key].Key;

            if (CustomerCacheDictionary.ContainsKey(key))
            {
                KeyValuePair<DateTime, object> keyValuePair = CustomerCacheDictionary[key];
                if (DateTime.Now > keyValuePair.Key)//过期了
                {
                    CustomerCacheDictionary.Remove(key);
                    return false;
                }
                else
                    return true;
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="func">真实查询数据源的方法</param>
        /// <returns></returns>
        public T GetT<T>(string key, Func<T> func)
        {
            T t;
            if (!this.Contains(key))
            {
                t = func.Invoke();
                this.Add(key, t);
            }
            else
            {
                t = this.Get<T>(key);
            }
            return t;
        }


        public object this[string key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void RemoveAll()
        {
            throw new NotImplementedException();
        }
    }
}
