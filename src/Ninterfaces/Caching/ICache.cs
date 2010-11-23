namespace Ninterfaces.Caching
{
    using System;
    using System.Web.Caching;

    public interface ICache
    {
        bool Contains(string key);

        object GetValue(string cacheKey);

        T Get<T>(string cacheKey);

        T Get<T>(string cacheKey, Func<T> loader);

        T Get<T>(string cacheKey, Func<string, T> loader);

        void Insert(string cacheKey, object value);

        void Insert(string cacheKey, object value, int seconds);

        void Insert(string cacheKey, object value, DateTime absoluteExpiration);

        void Insert(string cacheKey, object value, TimeSpan slidingExpiration);

        void Insert(string cacheKey, object value, CacheDependency dependency);

        void Insert(string cacheKey, object value, CacheDependency dependency, DateTime absoluteExiration, TimeSpan slidingExpitation, CacheItemPriority priority, CacheItemRemovedCallback callback);

        void Clear();

        void Remove(string cackeKey);

        void RemoveByPattern(string keyPattern);
    }
}
