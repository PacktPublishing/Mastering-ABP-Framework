using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;

namespace DemoApp
{
    public class MyUserService : ITransientDependency
    {
        private readonly IDistributedCache<UserCacheItem> _userCache;

        public MyUserService(IDistributedCache<UserCacheItem> userCache)
        {
            _userCache = userCache;
        }

        public async Task<UserCacheItem> GetUserInfoAsync(Guid userId)
        {
            return await _userCache.GetOrAddAsync(
                userId.ToString(), //Cache key
                async () => await GetUserFromDatabaseAsync(userId),
                () => new DistributedCacheEntryOptions
                {
                    AbsoluteExpiration = DateTimeOffset.Now.AddHours(1),
                    SlidingExpiration = TimeSpan.FromHours(1)
                    //AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1) //Alternative
                }
            );
        }

        private async Task<UserCacheItem> GetUserFromDatabaseAsync(Guid userId)
        {
            //TODO: Query from the database
            throw new NotImplementedException();
        }
    }
}