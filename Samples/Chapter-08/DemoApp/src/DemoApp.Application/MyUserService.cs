using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus;
using Volo.Abp.Identity;

namespace DemoApp
{
    public class MyUserService : 
        ILocalEventHandler<EntityChangedEventData<IdentityUser>>,
        ITransientDependency
    {
        private readonly IDistributedCache<UserCacheItem> _userCache;
        private readonly IRepository<IdentityUser, Guid> _userRepository;

        public MyUserService(
            IDistributedCache<UserCacheItem> userCache,
            IRepository<IdentityUser, Guid> userRepository)
        {
            _userCache = userCache;
            _userRepository = userRepository;
        }

        public async Task<UserCacheItem> GetUserInfoAsync(Guid userId)
        {
            return await _userCache.GetOrAddAsync(
                userId.ToString(), //Cache key
                async () => await GetUserFromDatabaseAsync(userId),
                () => new DistributedCacheEntryOptions
                {
                    //AbsoluteExpiration = DateTimeOffset.Now.AddHours(1),
                    //SlidingExpiration = TimeSpan.FromHours(1)
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1)
                }
            );
        }

        private async Task<UserCacheItem> GetUserFromDatabaseAsync(Guid userId)
        {
            var user = await _userRepository.GetAsync(userId);
            return new UserCacheItem
            {
                Id = user.Id,
                EmailAddress = user.Email,
                UserName = user.UserName
            };
        }

        public async Task HandleEventAsync(
            EntityChangedEventData<IdentityUser> data)
        {
            await _userCache.RemoveAsync(data.Entity.Id.ToString());
        }
    }
}