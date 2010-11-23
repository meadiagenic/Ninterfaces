namespace Ninterfaces.Caching
{
    using System;
    using System.Web.Caching;

    public abstract class CacheBase : ICache
    {
        static object locker = new object();

        public abstract bool Contains(string cacheKey);

        public abstract object GetValue(string cacheKey);

        public virtual T Get<T>(string cacheKey)
        {
            return Get<T>(cacheKey, () => default(T));
        }

        public T Get<T>(string cacheKey, Func<T> loader)
        {
            return Get<T>(cacheKey, (s) => loader());
        }

        public T Get<T>(string cacheKey, Func<string, T> loader)
        {
            T value = (T)GetValue(cacheKey);

            if (value == null)
            {
                lock (locker)
                {
                    value = (T)GetValue(cacheKey);
                    if (value == null)
                    {
                        value = loader(cacheKey);
                        Insert(cacheKey, value);
                    }
                }
            }
            return value;
        }

        public void Insert(string cacheKey, object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(string cacheKey, object value, int seconds)
        {
            throw new NotImplementedException();
        }

        public void Insert(string cacheKey, object value, DateTime absoluteExpiration)
        {
            throw new NotImplementedException();
        }

        public void Insert(string cacheKey, object value, TimeSpan slidingExpiration)
        {
            throw new NotImplementedException();
        }

        public void Insert(string cacheKey, object value, System.Web.Caching.CacheDependency dependency)
        {
            Insert(cacheKey, value, dependency, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, CacheItemPriority.Normal, null);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Remove(string cackeKey)
        {
            throw new NotImplementedException();
        }

        public void RemoveByPattern(string keyPattern)
        {
            throw new NotImplementedException();
        }

        public abstract void Insert(string cacheKey, object value, System.Web.Caching.CacheDependency dependency, DateTime absoluteExiration, TimeSpan slidingExpitation, CacheItemPriority priority, System.Web.Caching.CacheItemRemovedCallback callback);
    }
}
